namespace Fraction
{
    class Program
    {
        private static void Main(string[] args)
        {
            Fraction one = new Fraction(1, 4);
            Fraction two = new Fraction(4, 8);
            Fraction three = -one;
            Console.WriteLine($"+{one} = {+one}");
            Console.WriteLine($"-({one}) = {-one}");
            Console.WriteLine($"{one} + {two} = {one + two}");
            Console.WriteLine($"{one} - {two} = {one - two}");
            Console.WriteLine($"{one} * {two} = {one * two}");
            Console.WriteLine($"{one} / {two} = {one / two}");
            Console.WriteLine($"{one} == {two} : {one == two}");
            Console.WriteLine($"{one} != {two} : {one != two}");
            Console.WriteLine($"{one} > {two} : {one > two}");
            Console.WriteLine($"{one} < {two} : {one < two}");
            Console.WriteLine($"{one} >= {two} : {one >= two}");
            Console.WriteLine($"{one} <= {two} : {one <= two}");
            Console.WriteLine($"{one}++ = {++one}");
            Console.WriteLine($"{two}-- = {--two}");
            Console.WriteLine($"{one} = {(double)one}");
        }
    }
}