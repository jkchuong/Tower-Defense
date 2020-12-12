using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects
{
    class Level
    {
        private readonly Invader[] _invaders;
        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }


        // Return True if player wins, false otherwise
        public bool Play()
        {
            // Run until all invaders are dead or an invader reaches end of path
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                // Each tower has opportunity to fire on invaders
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }
                // Count and move the invaders that are still active
                remainingInvaders = 0;
                foreach(Invader invader in _invaders)
                {
                    if (invader.IsAlive)
                    {
                        invader.Move();

                        if (invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;
                    }
                }
            }

            return true;
        }
    }
}
