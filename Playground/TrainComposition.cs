using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    public class TrainComposition
    {
        public LinkedList<int> wagons;

        public TrainComposition()
        {
            wagons = new LinkedList<int>();
        }

        public void AttachWagonFromLeft(int wagonId)
        {
            this.wagons.AddFirst(wagonId);
        }

        public void AttachWagonFromRight(int wagonId)
        {
            this.wagons.AddLast(wagonId);
        }

        public int DetachWagonFromLeft()
        {
            int wagonId = this.wagons.First.Value;
            this.wagons.RemoveFirst();
            return wagonId;
        }

        public int DetachWagonFromRight()
        {
            int wagonId = this.wagons.Last.Value;
            this.wagons.RemoveLast();
            return wagonId;
        }
    }
}
