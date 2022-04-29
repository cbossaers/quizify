using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Quizify.Entities;

namespace Quizify.Persistence {

public class DALExamen : IDAL2<Examen> {
    static string connStr = "server=88.17.27.246;user=GrupoC;database=PSWC;port=3306;password=GrupoC";

    public void Add(Examen examen) {
        using(MySqlConnection conn = new MySqlConnection(connStr)) {

            using(MySqlCommand cmd = conn.CreateCommand()) {

                cmd.CommandText = "";
            }
        }
    }

    public void Get(string id) {

    }

    public void Eliminar(string id) {

    }

    public void Existe(int id) {

    }

}}