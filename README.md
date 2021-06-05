# Deagglutination_Hypothesis

* a) Deagglutination_Hypothesis
  * a.1) Program.cs -> Console application code
  * a.2) Resources -> Resources directory
    * a.2.a) Deagglutination Hypothesis.exe -> Executable application
    * a.2.b) Deagglutination_Class.dll -> Library
* b) Deagglutination_Class
  * b.1) Deagglutination_Class.cs -> Deagglutination class code



# a.1) Program.cs

* Main(string[]): Main method  
  * Run a loop using a for struct, where:
    - Begin with 0 (Type: uint32);
    - Run the IsPrimeNumber() method, from Deagglutination_Class.Deagglutination class;
    - Run the IsReallyPrime() method, to confirm the result from previus process
    - End with 4294967294 (Type: uint32).
    
* IsReallyPrime(uint): Prime number confirmation method  
  * Run a simple prime number verification process.

# b.1) Deagglutination_Class.cs
  
  * IsPrimeNumber(uint): Process where:
    * Will be excluded prime numbers to optimizing returned value speed, using basic prime number verify process;
    * Wheter the basic verification process do not work, will be applying process to apply the deagglutination hypothesis on received argument.
  * ApplyDeagglutination(uint, uint): Method to verify a possible prime number using the deagglutination hypothesis    
