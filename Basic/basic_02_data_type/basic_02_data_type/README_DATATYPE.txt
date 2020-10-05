///////////////////
*****DATA_TYPE*****
///////////////////

All .NET programming languages use the .NET data type defined in the .NET Common Type System.
You can refer to this link.
https://docs.microsoft.com/ko-kr/previous-versions/visualstudio/visual-studio-2008/2hf02550(v=vs.90)?redirectedfrom=MSDN

bool : True or False
byte : 8bit unsigned integer
sbyte : 8bit signed integer
short : 16bit signed integer
int : 32bit signed integer
long : 64bit signed integer
ushort : 16bit unsigned integer
uint : 32bit unsigned integer
ulong : 64bot unsigned integer
float : 32bit single precision (floating point)
double : 64bit double precision (floating point)
decimal : 128bit decimal (floating point)
char : 16bit unicode text
string : unicode string
DateTime : Date and Time
object : base class of any type can can contain any type 



//////////////////////
*****LITERAL_DATA*****
//////////////////////

Literal : In C# code, you can directly write values such as 123, true, and "abc", which are called literals.
When using literal data in C#, if there is no separate suffix, the C# compiler assigns the value to int, double, char, string, and bool data types by default.
Therefore, if you want to specify a secific data type, you need to add one or two character type designation suffixes after literal data.
Suffix is not case sensitive. That is, the suffix M representing decimal can be used like 1024M or 1024m. 

(DATA TYPE)    (Suffix)    (e.g.)
   long			  L	        1024L 
   uint	          U	        1024U
   ulong          UL        1024UL
   float          F         1024F
   double         D         10.24D or 10.24
   decimal        M         10.24M



///////////////////////
*****MAX_MIN_VALUE*****
///////////////////////

To find the maximum or minimum value of a numeric data type, use the MaxValue and MinValue properties of the .NET data type classes.
You can also call these properties directly after the c# data type keyword. 



//////////////
*****NULL*****
//////////////

NULL is used to mean that a variable does not have any data in memory. 
C# uses the keyword null in lowercase to represent NULL.
Not all data types can have NULL, and in fact, data types can be classified into a type that can have NULL (a reference type) and a type that cannot have (value type).



///////////////////////
*****NULLABLE_TYPE*****
///////////////////////

Value types such as integer (int) or date (DateTime) cannot generally have NULL. 
Since C# 2.0, these types can have NULL, which is called a Nullable Type.
