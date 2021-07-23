/*Написать программу вычисления стоимости покупки, состоящей из нескольких тетрадей
и такого же количества обложек к ним.*/
#include<iostream>

void main() 
{
	setlocale(LC_ALL, "Russian");
	double cena_tetradey;
	std::cout << "\t\t\tВведите цену тетради :" << std::endl;
	std::cin >> cena_tetradey;
	double cena_oblojka;
	std::cout << "\t\t\tВведите Цена обложки :" << std::endl;
	std::cin >> cena_oblojka;
	int kolichestvo_komplekt;
	std::cout << "\t\t\tВведите количество комплектов :" << std::endl;
	std::cin >> kolichestvo_komplekt;
	double stoimost_pokupki;
	stoimost_pokupki = (cena_tetradey + cena_oblojka) * kolichestvo_komplekt ;
	std::cout << "\t\t\tСтоимость покупки составляет " << stoimost_pokupki << " грн." << std::endl;
	std::cout << "\n ";
	std::cout << "\t\t\tдля завершения программы нажите enter" << std::endl;
	std::cin.get();

}