using System;
using CardClasses;

namespace BlackJack {
	class Program {
		static void Program1() {
			Random r = new();
			BJHand b = new();

			for (var i = 0; i < 7; i++) {
				Card c = new(r.Next(1, 4), r.Next(1, 13));

				b.AddCard(c);
			}

			Console.WriteLine("[PROBLEM #2]\n");
			Console.WriteLine($"BEFORE SORTING BY SCORE - [\n{b}]\n");

			b.Sort();

			Console.WriteLine($"AFTER SORTING BY SCORE - [\n{b}]\n");
		}

		static void Program2() {
			Deck d = new();
			BJHand b = new(d, 7);

			Console.WriteLine("[PROBLEM #3]\n");
			Console.WriteLine("GETTING CARDS IN LIST WITH FOREACH LOOP - [");
			foreach (Card c in b) Console.WriteLine(c);
			Console.WriteLine("]");
		}

		static void Main() {
			Program1();
			Program2();
		}
	}
}