using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game state
    int nivelActual;
    enum Pantalla { MenuPrincipal, Contrasenia, Gano };
    Pantalla pantallaActual = Pantalla.MenuPrincipal;

    // Use this for initialization
    void Start()
    {
        mostrarMenuPrincipal();
        print("Hello " + "World");
    }

    void mostrarMenuPrincipal()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("A donde deseas hackear?");
        Terminal.WriteLine("Presiona 1 para la casa abierta del vecino.");
        Terminal.WriteLine("Presiona 2 para la biblioteca de la esquina.");
        Terminal.WriteLine("Ingrese la opcion: ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            mostrarMenuPrincipal();
        }
        else if (input == "1")
        {
            nivelActual = 1;
            StartGame();
        }
        else if (input == "2")
        {
            nivelActual = 2;
            StartGame();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Por favor elegir un nivel Mr. Bond!");
        }
        else
        {
            Terminal.WriteLine("Por favor elegir un nivel valido.");
        }
    }

    void StartGame()
    {
        Terminal.WriteLine("Has elegido el nivel: " + nivelActual);
        pantallaActual = Pantalla.Contrasenia;
        Terminal.WriteLine("Escriba su contraseña: ");
    }
}
