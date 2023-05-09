
// Wyjątki
try {
    ...
}
catch (DivideByFiveException e) { 
    Console.WriteLine(e.Message); 
}
finally {
    ...
}
static float Dzielenie(int a) {
    if (a == 5) { throw new DivideByFiveException("Wystąpił błąd dzielenia przez 5."); }
    return 10 / a;
}


class DivideByFiveException: Exception {
    public DivideByFiveException() { }
    public DivideByFiveException(string _message) : base(_message) { }
}
