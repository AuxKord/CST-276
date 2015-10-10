using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{

    class Morg
    {
        private double location;
        private double direction;
        private List<IMorgObserver> observers;
        private List<IMoveBehavior> m_observers;
        private List<IFeedBehavior> f_observers;

        public void UpdatePosition() { }

        public void RegisterObserver ( IMorgObserver o ) { observers.Add(o); }
        public void RemoveObserver   ( IMorgObserver o ) { observers.Remove(o); }

        public void RegisterObserver ( IMoveBehavior m ) { m_observers.Add(m);  }
        public void RemoveObserver   ( IMoveBehavior m ) { m_observers.Remove(m);  }

        public void RegisterObserver ( IFeedBehavior f ) { f_observers.Add(f);  }
        public void RemoveObserver   ( IFeedBehavior f ) { f_observers.Remove(f); }


    }

    class Paddle : IMoveBehavior
    {
        private Morg move;

        public Paddle ( Morg p )
        {
            move = p;
            move.RegisterObserver(this);
        }
    }

    class Ooze : IMoveBehavior
    {
        private Morg move;

        public Ooze ( Morg oo )
        {
            move = oo;
            move.RegisterObserver(this);
        }
    }
}
