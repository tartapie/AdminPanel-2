﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Models
{
    //унаследуем наш ApplicationContext от DbCOntext (через знак " : ")
    public class ApplicationContext: IdentityDbContext<User>
    {
        //в БД появится таблица Users после миграции.
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<News> News { get; set; } = null!;
        public DbSet<NewsPictures> Pictures { get; set; } 
        public DbSet<Teachers> Teachers { get; set; } 
        public DbSet<Achievements> Achievements { get; set; } 


        //созаем конструктор ApplicationContext, чтоб можно было инициализировать объекты класса AppliCationContext в других
        //классах (контроллеры  втом числе)

        //DbContextOptions служит для установки подключения БД через options,
        //в нашем случае по умолчанию нет никакх значений
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {

        }
    }
}
