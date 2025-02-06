// See https://aka.ms/new-console-template for more information

//MyEvents.finalizar = () => { Console.WriteLine("Suscriptor A"); };
//MyEvents.finalizar += () => { Console.WriteLine("Suscriptor B"); };

using HilosGenericos;

FinishEvent finishEvent = new FinishEvent();

Wrapper<Action> finishEvent2 = new Wrapper<Action>(() => { });

MiHilo t1 = new MiHilo("x", finishEvent2);
MiHilo t2 = new MiHilo("y", finishEvent2);

finishEvent.FinishAction += () => { Console.WriteLine("Suscriptor C"); };

t1.Start();
t2.Start();