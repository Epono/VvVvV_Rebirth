using System;

namespace Unite
{
	public class Action
	{
		int cost_in_pa;


		public Action (int id)
		{
			switch (id) {
			case 0:
				MoveTo (1);
				break;
			case 1:
				PutTrap (1);
				break;
			case 2:
				Wait ();
				break;

			}




		}

		public void MoveTo(int go_to)
		{
			cost_in_pa = 1;
		}

		public void Wait()
		{
			cost_in_pa = 3;
		}

		public void PutTrap(int pos)
		{

			cost_in_pa = 2;
		}



		void setCostPA(int _value)
		{
			cost_in_pa = _value;
		}

		public int getCostPa()
		{
			return cost_in_pa;
		}

		/*
		public void setAction(Action _action_to_do)
		{
			action_to_do = _action_to_do;
			Console.WriteLine ("Action ADD to task");
		}

		public Action getAction()
		{
			return action_to_do;
		}*/

	}
}

