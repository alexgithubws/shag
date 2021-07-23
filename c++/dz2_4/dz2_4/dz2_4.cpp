#include<iostream>
using namespace std;

//ПРОГРАММА ДЛЯ РАСЧЁТА СТОИМОСТИ ПОЕЗДКИ НА ДАЧУ
void main()

{
    setlocale(LC_ALL, "Russian");
    float distancya, stoimost_poezdki, rashod_topliva, cena_benzina;
    cout << " \t\tПРОГРАММА ДЛЯ РАСЧЁТА СТОИМОСТИ ПОЕЗДКИ НА ДАЧУ\n ";
    cout << "Введите расстояние до дачи в километрах: ";
    cin >> distancya;
    cout << "\n ";
    cout << "Введите расход бензина в литрах на 100 километров: ";
    cin >> rashod_topliva;
    cout << "\n ";
    cout << "Введите стоимость бензина в гривнах за литр: ";
    cin >> cena_benzina;
    cout << "\n ";
    stoimost_poezdki = (((distancya * rashod_topliva) / 100) * cena_benzina) * 2;
    cout << "Поездка на дачу обойдётся в: " << stoimost_poezdki << " гривен \n ";
    cout << "\n ";
    cout << "\t\t\tдля завершения программы нажите enter" << endl;
    cin.get();

}