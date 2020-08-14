﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.DataAccess.Interfaces
{
    public interface IGorevDal : IGenericDal<Gorev>
    {
        List<Gorev> GetirAciliyetIleTamamlanmayan();
        List<Gorev> GetirTumTablolarla();
        List<Gorev> GetirTumTablolarlaTamamlanmayan(out int toplamSayfa,int userId,int aktifSayfa);
        List<Gorev> GetirTumTablolarla(Expression<Func<Gorev,bool>> filter);
        Gorev GetirAciliyetileId(int id);
        List<Gorev> GetirileAppUserId(int appUserId);
        Gorev GetirRaporlarileId(int id);

        int GetirGorevSayisiTamamlananileAppUserId(int id);
        int GetirGorevSayisiTamamlanmasıGerekenileAppUserId(int id);
        int AtanmayiBekleyenGorevSayisi();
        int TamamlanmisGorevSayisi();

    }
}
