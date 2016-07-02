using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGames.Slots
{
    class BasicSlots
    {
        public List<SlotReel> Reels { get; set; } = new List<SlotReel>();
        public int Rows { get; set; }
        public double Play(int Rows, double BaseAmount, string Server, string Client, int Nonce)
        {
            List<SlotItem[]> VisibleItems = new List<SlotItem[]>();
            int reelno = 0;
            foreach (SlotReel s in Reels)
            {
                VisibleItems.Add(s.GetItems((int)GetLucky(Server, Client, Nonce, reelno++)/s.ReelItems.Count, this.Rows));
            }

            return -BaseAmount * Rows;
        }
        public double GetLucky(string server, string client, int nonce, int Reel)
        {
            HMACSHA512 betgenerator = new HMACSHA512();

            int charstouse = 5;
            List<byte> serverb = new List<byte>();

            for (int i = 0; i < server.Length; i++)
            {
                serverb.Add(Convert.ToByte(server[i]));
            }

            betgenerator.Key = serverb.ToArray();

            List<byte> buffer = new List<byte>();
            string msg = /*nonce.ToString() + ":" + */ Reel +":"+client + ":" + nonce.ToString();
            foreach (char c in msg)
            {
                buffer.Add(Convert.ToByte(c));
            }

            byte[] hash = betgenerator.ComputeHash(buffer.ToArray());

            StringBuilder hex = new StringBuilder(hash.Length * 2);
            foreach (byte b in hash)
                hex.AppendFormat("{0:x2}", b);


            for (int i = 0; i < hex.Length; i += charstouse)
            {

                string s = hex.ToString().Substring(i, charstouse);

                double lucky = int.Parse(s, System.Globalization.NumberStyles.HexNumber);
                if (lucky < 1000000)
                    return lucky / 10000;
            }
            return 0;
        }
    }

}
