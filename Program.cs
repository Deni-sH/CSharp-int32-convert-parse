
int -2.147.483.648 ~ 2.147.483.647
uint 2.147.483.648 x2 
long = - 9.223.372.036.854.775.808 ~ 9.223.372.036.854.775.807

double = coordenadas 
float menos preciso
decimal = monetario / preciso

Toint32 = bilhoes
Toint64 = trilhoes
----------------------------------------
cast = casting

int a = Convert.Toint32("5"); = virou string

int a = int.Parse("5"); = transformou string em numero inteiro


int a = Convert.Toint32(null); = 0
já o
int a = int.Parse(null); = error 
-------------------------------------------
String

int inteiro = 5;
string a = inteiro.ToString(); = 5; ToString transforma qualquer tipo em string
-------------------------------------------
Cast implícito

int a = 5;
double b = a;


Console.WriteLine(a);

