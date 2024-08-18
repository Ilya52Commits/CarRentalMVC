﻿using CarRentalMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalMVC.Repository;

public class SQLUserRepository : IRepository<User>
{
    private ApplicationContext _dbContent;

    public SQLUserRepository(ApplicationContext context)
    {
        _dbContent = context;
    }

    public IEnumerable<User> GetUserList()
    {
        return _dbContent.Users;
    }

    public User GetUser(int id)
    {
        return _dbContent.Users.Find(id);
    }

    public void Create(User User)
    {
        _dbContent.Users.Add(User);
    }

    public void Update(User User)
    {
        _dbContent.Entry(User).State = EntityState.Modified;
    }

    public void Delete(int id)
    {
        User User = _dbContent.Users.Find(id);
        if (User != null)
            _dbContent.Users.Remove(User);
    }

    public void Save()
    {
        _dbContent.SaveChanges();
    }

    private bool disposed = false;

    public virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                _dbContent.Dispose();
            }
        }
        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}   