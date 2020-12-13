﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjects
{
    class ResInvader : InterInvader
    {

        private BasicInvader _incarnation1;
        private StrongInvader _incarnation2;

        public MapLocation Location => _incarnation1.IsDead ? _incarnation2.Location : _incarnation1.Location;

        public int Health => _incarnation1.IsDead ? _incarnation1.Health : _incarnation2.Health;

        public bool HasScored => _incarnation1.HasScored || _incarnation2.HasScored;

        public bool IsDead => _incarnation1.IsDead && _incarnation2.IsDead;

        public bool IsAlive => !(IsDead || HasScored);


        public ResInvader(Path path)
        {
            _incarnation1 = new BasicInvader(path);
            _incarnation2 = new StrongInvader(path);
        }

        public void Move()
        {
            _incarnation1.Move();
            _incarnation2.Move();
        }

        public void Damage(int factor)
        {
            if(!_incarnation1.IsDead)
            {
                _incarnation1.Damage(factor);
            }
            else
            {
                _incarnation2.Damage(factor);
            }
        }
    }
}
