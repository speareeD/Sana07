namespace Fraction
{
    class Program
    {
        private static void Main(string[] args)
        {
            Fraction one = new Fraction(1, 4);
            Fraction two = new Fraction(4, 8);
            Fraction three = new Fraction(5);
            Console.WriteLine(three);
            Console.WriteLine($"+{one} = {+one}");
            Console.WriteLine($"-({one}) = {-one}");
            Console.WriteLine($"{one} + {two} = {one + two}");
            Console.WriteLine($"{one} - {two} = {one - two}");
            Console.WriteLine($"{one} * {two} = {one * two}");
            Console.WriteLine($"2 * {two} = {2 * two}");
            Console.WriteLine($"{one} * 2 = {one * 2}");
            Console.WriteLine($"{one} / {two} = {one / two}");
            Console.WriteLine($"2 / {two} = {2 / two}");
            Console.WriteLine($"{one} / 2 = {one / 2}");
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