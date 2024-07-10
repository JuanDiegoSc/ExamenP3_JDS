﻿using ExamenP3_JDS.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP3_JDS
{
    public class PersonajeRepositoryJDS
    {
            string _dbPath;

            public string StatusMessage { get; set; }

            // TODO: Add variable for the SQLite connection
            private SQLiteConnection connJDS;
            private void Init()
            {
                // TODO: Add code to initialize the repository         
                if (connJDS != null)
                {
                    return;
                }

                connJDS = new SQLiteConnection(_dbPath);
                connJDS.CreateTable<PersonajesJDS>();
            }

            public PersonajeRepositoryJDS(string dbPath)
            {
                _dbPath = dbPath;
            }

            public void AddNewPerson(string name)
            {
                int result = 0;
                try
                {
                    // TODO: Call Init()
                    Init();

                    // basic validation to ensure a name was entered
                    if (string.IsNullOrEmpty(name))
                        throw new Exception("Valid name required");

                    // enter this line
                    result = connJDS.Insert(new PersonajesJDS { name = name });

                // basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(name))
                        throw new Exception("Valid name required");

                    // TODO: Insert the new person into the database
                    result = 0;

                    StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
                }
                catch (Exception ex)
                {
                    StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
                }
            }

            public List<PersonajesJDS> GetAllPeople()
            {
                // TODO: Init then retrieve a list of Person objects from the database into a list
                try
                {
                    Init();
                    return connJDS.Table<PersonajesJDS>().ToList();
                }
                catch (Exception ex)
                {
                    StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
                }

                return new List<PersonajesJDS>();
            }

        }
    }
