using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoGames.Slots
{
    class SlotItem
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public SlotItemEffect Effect { get; set; }
        public string Image { get; set; }
    }

    class SlotReel
    {
        public List<SlotItem> ReelItems { get; set; } = new List<SlotItem>();

        public SlotItem[] GetItems(int Index, int Items)
        {
            throw new NotImplementedException();
        }
    }

    public enum SlotItemEffect
    {
        None,Payout,FreeSpin
    }
}
