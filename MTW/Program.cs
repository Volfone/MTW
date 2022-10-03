using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MTW;

Blacksmith blacksmith = new Blacksmith();
Kunai kuani = new Kunai();
Shuriken shuriken = new Shuriken();
Tanto tanto = new Tanto();
Human human = new Human("Name");
Human human2 = new Human("Nmae1");
human.Attack(kuani, human2);/*
human.Attack(shuriken, human2);*/
human.Attack(tanto, human2);
human.Throw(kuani, human2);
human.Throw(shuriken, human2);/*
human.Throw(tanto, human2);*/
blacksmith.Upgrade(kuani);
human.Attack(kuani, human2);
human.Attack(kuani, human2);/*
human.Attack(shuriken, human2);*/
human.Attack(tanto, human2);
human.Throw(kuani, human2);
human.Throw(shuriken, human2);/*
human.Throw(tanto, human2);*/
human.Attack(kuani, human2);/*
human.Attack(shuriken, human2);*/
human.Attack(tanto, human2);
human.Throw(kuani, human2);
human.Throw(shuriken, human2);/*
human.Throw(tanto, human2);*/
human.Attack(kuani, human2);/*
human.Attack(shuriken, human2);*/
human.Attack(tanto, human2);
human.Throw(kuani, human2);
human.Throw(shuriken, human2);/*
human.Throw(tanto, human2);*/
human.Attack(kuani, human2);/*
human.Attack(shuriken, human2);*/
human.Attack(tanto, human2);
human.Throw(kuani, human2);
human.Throw(shuriken, human2);/*
human.Throw(tanto, human2);*/
human.Attack(kuani, human2);/*
human.Attack(shuriken, human2);*/
human.Attack(tanto, human2);
human.Throw(kuani, human2);
human.Throw(shuriken, human2);/*
human.Throw(tanto, human2);*/
human.Attack(kuani, human2);/*
human.Attack(shuriken, human2);*/
human.Attack(tanto, human2);
human.Throw(kuani, human2);
human.Throw(shuriken, human2);/*
human.Throw(tanto, human2);*/

blacksmith.Repair(tanto);
human.Attack(kuani, human2);/*
human.Attack(shuriken, human2);*/
human.Attack(tanto, human2);
human.Throw(kuani, human2);
human.Throw(shuriken, human2);/*
human.Throw(tanto, human2);*/