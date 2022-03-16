using System;
using System.Collections.Generic;

namespace Quizify.Entities{
public partial class Examen
{   
    public int ID {
        get;
        set;
    }
    public string titulo {
        get;
        set;
    }
    public string descripcion {
        get;
        set;
    }
    public string autor {
        get;
        set;
    }
    public string curso {
        get;
        set;
    }
    public int tiempo {
        get;
        set;
    }
    public DateTime fecha_creac {
        get;
        set;
    }
    public DateTime fecha_ini {
        get;
        set;
    }
    public DateTime fecha_fin {
        get;
        set;
    }
    public int intentos {
        get;
        set;
    }
    public int volver_atras {
        get;
        set;
    }
    public int errores_restan {
        get;
        set;
    }
    public int mostrar_resultados {
        get;
        set;
    }

    public List<int> preguntas_asociadas {
        get;
        set;
    }
}
}