//Digite un programa que 
//A-Excelente,B-Bueno,C-regular,
//D-Deficiente,F-Reprobado
Algoritmo Letras
    Definir l Como Caracter
    
    // Interfaz de usuario
    Escribir "*** MENÚ DE CALIFICACIONES ***"
    Escribir "Ingrese una letra (A, B, C, D o F):"
    Leer l
    l = Mayusculas(l)
    
    // Opciones
    Segun l Hacer
        "A":
            Escribir "Resultado: Excelente"
        "B":
            Escribir "Resultado: Bueno"
        "C":
            Escribir "Resultado: Regular"
        "D":
            Escribir "Resultado: Deficiente"
        "F":
            Escribir "Resultado: Reprobado"
        De Otro Modo:
            Escribir "Error: Letra no válida."
    Fin Segun
    
FinAlgoritmo