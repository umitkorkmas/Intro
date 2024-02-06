using Intro.Business;
using Intro.Entitites;

string message1 = "Krediler";
int term = 12;
double amount = 100000;


//variables -- camelCase
bool isAuthanticated = true;
//condition 
if (isAuthanticated == true)
{
    Console.WriteLine("Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Buton --> Giriş Yap butonu");
}

string[] loans = {"Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5", "Kredi6"};
//string[] loans2 = new string[6];
//loans[0] = "kredi1";

         //start     //condition  //increment  
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name);
}