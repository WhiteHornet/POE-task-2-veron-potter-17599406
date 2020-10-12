﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    class Mage : Unit
    {
        public int XPos
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public int YPos
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public int Range
        {
            get { return range; }
            set { range = value; }
        }

        public int Faction
        {
            get { return faction; }
            set { faction = value; }
        }

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public Mage(int x, int y, int health, int attack, int speed, int range, int faction, string symbol)
        {
            XPos = x;
            YPos = y;
            Health = 5;
            Attack = 5;
            Speed = speed;
            Range = range;
            Faction = faction;
            Symbol = symbol;
        }

        public override void Move(Direction d)
        {
            switch (d)
            {
                case Direction.North:
                    {
                        YPos -= Speed;
                        break;
                    }
                case Direction.East:
                    {
                        XPos += Speed;
                        break;
                    }
                case Direction.South:
                    {
                        YPos += Speed;
                        break;
                    }
                case Direction.West:
                    {
                        XPos -= Speed;
                        break;
                    }
            }
        }
        public override void Combat(Unit u)
        {
            if (u.GetType() == typeof(Mage))
            {
                Health -= ((Mage)m).Attack;
            }

        }
        public override bool IsDead()
        {
            if (Health <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override Unit Closest(Unit[] units)
        {
            Unit closest = this;
            int closestDistance = 50;
            foreach (Unit u in units)
            {
                if (u.GetType() == typeof(Mage))
                {
                    if (((Mage)u).Faction != Faction && ((Mage)u).IsDead() == false)
                        if (DistanceTo(u) < closestDistance)
                        {
                            closest = u;
                            closestDistance = DistanceTo(u);
                        }
                }

            }
            return closest;
        }
        public override bool inRange(Unit u)
        {
            if (u.GetType() == typeof(Mage))
            {
                Mage m = (Mage)u;

                if (DistanceTo(u) <= Range)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public override string ToString()
        {
            return "RU: " + XPos + ", " + YPos + ", " + Health;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        private int DistanceTo(Unit u)
        {
            if (u.GetType() == typeof(Mage))
            {
                Mage m = (Mage)m;
                int d = Math.Abs(XPos - r.XPos) + Math.Abs(YPos - r.YPos);
                return d;

            }
            else
            {
                return 0;
            }
        }

        public Direction DirectionTo(Unit u)
        {
            if (u.GetType() == typeof(Mage))
            {
                Mage m = (Mage)u;
                if (m.XPos < XPos)
                {
                    return Direction.North;
                }
                else if (m.YPos > YPos)
                {
                    return Direction.East;
                }
                else if (m.XPos > XPos)
                {
                    return Direction.South;
                }
                else
                {
                    return Direction.West;
                }
            }
            else
            {
                return Direction.North;
            }


        }

    }
}

