#include<iostream>

#define LOGICAL_TYPES
#define SYMBOL_TYPES

void main()
{
	setlocale(LC_ALL, "Russian");
	/*std::cout << false << std::endl;
	std::cout << (bool)-123 << std::endl;
	bool is_summer = false;
	bool is_day = true;*/

	/*char symbol = '+';
	std::cout << symbol << std::endl;*/

	//×èñåë ñ ïëàâàþùåé çàïÿòîé (Floating Point)
	//çíàêîâûìè (signed) áåççíàêîâûìè (unsigned)
	//short, long, int è long long;

	//int (Integer - Öåëîå ÷èñëî)

	//long long
	/*std::cout << sizeof(int) << std::endl;
	std::cout << INT_MIN << "\t" << INT_MAX << std::endl;*/

	//float  - îäèíàðíîé òî÷íîñòè, 4B;
	//double - äâîéíîé òî÷íîñòè, 8B;
	/*std::cout << FLT_MIN << "\t" << FLT_MAX << std::endl;
	std::cout << DBL_MIN << "\t" << DBL_MAX << std::endl;*/

	//double price_of_coffee = 10;	//snake_case_style
	//double priceOfCoffee = 15;		//Pascal (Camel) case style
	//int discount = 15;
	//int t;
	//int a;
	//std::cout << "Ââåäèòå çíà÷åíèå: ";
	//std::cin >> a;
	//std::cout << priceOfCoffee << std::endl;
	//std::cout << a << std::endl;

	//Èíèöèàëèçàöèÿ - ïðèñâîåíèå íà÷àëüíîãî çíà÷åíèÿ.
	//Init - Íà÷àëî.
	//Ïðîèíèöèàëèçèðîâàòü
	//Íå ïðîèíèöèàëèçèðîâàííàÿ ïåðåìåííàÿ
	//Run-time check failure #3

	//unsigned int speed = 0;
	//const unsigned int MAX_SPEED = 250;
	//std::cout << speed << std::endl;
	//std::cout << MAX_SPEED << std::endl;
	//std::cout << "Ñ êàêîé ñêîðîñòüþ Âû õîòèòå åõàòü? ";
	//std::cin >> speed;
	////MAX_SPEED = 300;
	//std::cout << speed << std::endl;
	//std::cout << MAX_SPEED << std::endl;


	250;	//×èñëîâàÿ êîíñòàíòà òèïà int
	3.14;	//×èñëîâàÿ êîíñòàíòà òèïà double
	3.14f;	//×èñëîâàÿ êîíñòàíòà òèïà float
	std::cout << typeid(250.f).name() << std::endl;
	'+';	//Ñèìâîëüíàÿ êîíñòàíòà òèïà char
	std::cout << '+' << std::endl;
	std::cout << "+" << std::endl;
	std::cout << sizeof('+') << std::endl;
	std::cout << "Hello" << std::endl;
	std::cout << sizeof("Hello") << std::endl;
}

//	identifier - ýòî èìÿ.
/*
	1. ABC...Zabc...z012...9_
	2. 1stPerson
	3.*/
