// Algoritmo que muestra el día de la semana según el número
Algoritmo DiasDeLaSemana
	// Variables
	Definir num_dia Como Entero
	Escribir '== DIAS DE LA SEMANA =='
	// Solicitar datos al usuario
	Escribir 'Ingrese un numero del 1 al 7:'
	Leer num_dia
	// Evaluación
	Segun num_dia Hacer
		1:
			Escribir "Lunes"
		2:
			Escribir "Martes"
		3:
			Escribir "Miércoles"
		4:
			Escribir "Jueves"
		5:
			Escribir "Viernes"
		6: 
			Escribir "Sábado"
		7: 
			Escribir "Domingo"
			
		De Otro Modo:
			Escribir "Digite un número entre el 1 y el 7"
	Fin Segun
FinAlgoritmo