//Pide dos números y una opción: 1 ? sumar,
//2 ? Restar, 3 ? Multiplicar, 4? dividir - Muestra el 
//Resultado según la opción elegida
Algoritmo CalCBasic
	Definir operaciones Como Entero
	Definir num1, num2 Como Entero
	
	Escribir "***********************"
	Escribir "*   MENÚ DE OPCIONES  *"
	Escribir "1- suma"
	Escribir "2- resta"
	Escribir "3- multiplicacion"
	Escribir "4- división"
	
	Escribir Sin Saltar "Digite la opción []"
	Leer operaciones
//	Escribir "Digite dos valores numericos: "
	Leer num1
	Leer num2
	
	Segun operaciones Hacer
		1:
			Escribir "La suma es: ", (num1+num2)
		2:
			Escribir "La resta es: ",(num1-num2)
		3:
			Escribir "La multiplicación es: ", (num1*num2)
	    4:
			Escribir "La división es: ", (num1/num2)
		De Otro Modo:
			Escribir "Error al operar los numeros!!!"
	Fin Segun
	
	
FinAlgoritmo
