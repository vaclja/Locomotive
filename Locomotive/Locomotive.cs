using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locomotive;

public class Locomotiva
{
    private Person driver;
    public Person Driver
    {
        get { return driver; }
        set { driver = value; }
    }
    private Engine engine;

    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }
    public Locomotiva()
    {
        // Výchozí konstruktor
    }
    public Locomotiva(Person driver, Engine engine)
    {
        this.driver = driver;
        this.engine = engine;
    }

    public override string ToString()
    {
        return $"Řidič: {driver}, Motor: {engine}";
    }
}
