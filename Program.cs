using static System.Console;
using poo_project.src.Entities;

Knight arus = new Knight("Arus", 23, "Knight");
Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

WriteLine(arus.Attack());
WriteLine(wizard.Attack(1));
