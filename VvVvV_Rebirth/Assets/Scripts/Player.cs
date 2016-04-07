using System;
using System.Collections.Generic;
namespace Unite
{
	public class Player
	{

		List<Action> task_list;
		Task actualTask;

		int action_point;
		int max_action_point;

		public Player ()
		{
			max_action_point = 10;
			action_point = max_action_point;


			task_list = new List<Action> ();

		}

		public void InitNewTurn()
		{

			RemoveAllTaskToDo ();
			action_point = max_action_point;

			Console.WriteLine ("We are ready for a new turn");
			Console.WriteLine ("action Point :" + action_point); 

		}

		public void ExecuteTurn ()
		{
			//Unity code a 100 %%%%%%


		}

		public void EndTurn()
		{
			Console.WriteLine ("TASK TO DO : " + task_list.Count );
			Console.WriteLine ("action Point :" + action_point );
		}


		public void AddTaskToDo(int _idAction)
		{
			Action myAct = new Action (_idAction);
			task_list.Add (myAct);
			SoustractActionPoint (myAct.getCostPa ());
			Console.WriteLine ("Nouvelle tâche ajouté à la liste !");
		}

		public void RemoveAllTaskToDo()
		{

			task_list.RemoveRange (0, task_list.Count );
			action_point = max_action_point;
			Console.WriteLine ("Liste des taches purgé!");
		}

		public void RemoveLastAddedTaskToDo()
		{
			AddActionPoint (task_list [task_list.Count - 1].getCostPa ());

			task_list.RemoveAt(task_list.Count - 1);
			Console.WriteLine ("Derniere tache supprimé!");
		}

		public void AddActionPoint(int _value)
		{
			action_point += _value;
		}

		public void SoustractActionPoint(int _value)
		{
			action_point -= _value;
		}

		public void SetMaxPointAction( int _value)
		{
			max_action_point = _value;
		}

		public int GetMaxPointAction()
		{
			return max_action_point;
		}
	}
}

