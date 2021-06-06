# Deagglutination_Hypothesis

* a) Deagglutination_Hypothesis
  * a.1) [Program.cs](https://github.com/caiolopssants/Deagglutination_Hypothesis/blob/master/Deagglutination_Hypothesis/Program.cs) -> Console application code
  * a.2) [Resources](https://github.com/caiolopssants/Deagglutination_Hypothesis/tree/master/Deagglutination_Hypothesis/Resources) -> Resources directory
    * a.2.a) Deagglutination Hypothesis.exe -> Executable application
    * a.2.b) Deagglutination_Class.dll -> Library
* b) Deagglutination_Class
  * b.1) [Deagglutination_Class.cs](https://github.com/caiolopssants/Deagglutination_Hypothesis/blob/master/Deagglutination_Class/Deagglutination_Class.cs) -> Deagglutination class code



## a.1) Program.cs

* Main(string[]): Main method  
  * Options:
    * a) Show all number (red - Prime number || white - non prime number);
    * b) Show prime numbers only;
    * c) Verify value;
  ### a) Show all number (red - Prime number || white - non prime number)
   * Run a loop using a for struct, where:  
       - Begin with 0 (Type: uint64 or ulong);
       - Run the IsPrimeNumber() method, from Deagglutination_Class.Deagglutination class;
       - Run the IsReallyPrime() method, to confirm the result from previus process (**desactived**)
       - End with 18446744073709551614 (Type: uint64 or ulong).
   * If the current value be a prime number, will be writed with a red color, otherwise, white color;
   * For each non prime number, will be added a '.'  until a prime number be found.
   ### b) Show prime numbers only
   * Run a loop using a for struct, where:  
       - Begin with 0 (Type: uint64 or ulong);
       - Run the IsPrimeNumber() method, from Deagglutination_Class.Deagglutination class;
       - Run the IsReallyPrime() method, to confirm the result from previus process (**desactived**)
       - End with 18446744073709551614 (Type: uint64 or ulong).
   ### c) Verify value
   * User will inform a value and will be return wheter or not are a prime number 
 
* IsReallyPrime(ulong): Prime number confirmation method  
  * Run a simple prime number verification process.

## b.1) Deagglutination_Class.cs
  
  * IsPrimeNumber(ulong): Process where:
    * Will be excluded prime numbers to optimizing returned value speed, using basic prime number verify process;
    * Wheter the basic verification process do not work, will be applying process to apply the deagglutination hypothesis on received argument.
  * ApplyDeagglutination(ulong, ulong): Method to verify a possible prime number using the deagglutination hypothesis    



