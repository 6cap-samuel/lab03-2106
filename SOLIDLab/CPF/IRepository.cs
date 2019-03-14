using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CPF
{
    /**
     * Use of interface so that implementing class is
     * open to extension but closed for modification
     *
     * Ensures that all concrete repository classes have
     * and Add() function, makes use of generics so that
     * implementing repository classes can perform CRUD
     * actions on various models
     */
    interface IRepository<T>
    {
        string Add(T model);
    }
}
