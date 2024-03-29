﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SinavSistemi.Models;

namespace SinavSistemi.DataContex
{
    public class CreateAQuizDb : IdentityDbContext<AppUser>
    {
        public CreateAQuizDb(DbContextOptions options) : base(options)
        {
        }// 
       /// <summary>
       ///  proje tamamlandı
       /// </summary>
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<New> News { get; set; }
    }
}
