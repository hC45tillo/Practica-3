﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	#region SINGLETON
	protected static GameManager _instance = null;
	public static GameManager instance { get { return _instance; } }
	void Awake () { _instance = this; }
	#endregion

	// Punteros a player y a todos los enemigos (lista 'enemiesList')
	public PlayerBehaviour player = null;
	public List<SkeletonBehaviour> enemiesList = null;	// No requiere inicializacion, se rellena desde el Inspector

	// Lista con los enemigos que quedan vivos
	List<SkeletonBehaviour> currentEnemiesList = null;

	// Variables internas
	int _score = 0;
	public bool soundEnabled = true;


	void Start ()
	{
		currentEnemiesList = new List<SkeletonBehaviour>();
		
		// Reiniciamos el juego
		// TODO
	}

	private void reset()		// Funcion para reiniciar el juego
	{
		// Reiniciamos a Player
		// TODO

		// Incializamos la puntuacion a cero
		// TODO

		// Rellenamos la lista de enemigos actual.
		currentEnemiesList.Clear();
		foreach (SkeletonBehaviour skeleton in enemiesList)
		{
			skeleton.setPlayer(player);
			skeleton.reset();

			currentEnemiesList.Add(skeleton);
		}
	}

	#region UI EVENTS
	// Evento al pulsar boton 'Start'
	public void onStartGameButton()
	{
		// Ocultamos el menu principal (UIManager)
		// TODO

		// Actualizamos la puntuacion en el panel Score (UIManager)
		// TODO

		// Quitamos la pausa a Player
		// TODO
	}

	// Evento al pulsar boton 'Exit'
	public void onExitGameButton()
	{
		// Mostramos el panel principal
		// TODO

		// Reseteamos el juego
		// TODO
	}
	#endregion

	#region GAME EVENTS
	// Evento al ser notificado por un enemigo (cuando muere)
	public void notifyEnemyKilled(SkeletonBehaviour enemy)
	{
		// Eliminamos enemigo de la lista actual
		currentEnemiesList.Remove(enemy);

		// Subimos 10 puntos y actualizamos la puntuacion en la UI
		// TODO

		// Si no quedan enemmigos
		if (currentEnemiesList.Count == 0)	// KEEP
		{
			// Mostrar panel de 'Mision cumplida' y pausar a Player
			// TODO
		}
	}

	// Evento al ser notificado por player (cuando muere)
	public void notifyPlayerDead()
	{
		// Mostrar panel de 'Mision fallida' y pausar a Player
		// TODO
	}
	#endregion
}
