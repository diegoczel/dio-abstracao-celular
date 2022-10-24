using CelularConsole.Models;

IphoneTest();
NokiaTest();


void IphoneTest()
{
    var iphone = new Iphone("1", "pro 14", "imei 1", 128);
    iphone.InstalarAplicativo("PartyPoker");
}

void NokiaTest()
{
    var nokia = new Nokia("2", "e71", "imei 2", 2);
    nokia.InstalarAplicativo("Calculadora científica");
}