using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Singleton<T> where T : class, new()
{

    private static T _instance;
    public static T instance
    {
        //lazy instantiation
        get
        {
            if (_instance == null) // if the instance of Slam does not exist
                _instance = new T();
            return _instance;
        }
    }
}

