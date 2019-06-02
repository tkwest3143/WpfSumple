using System;
using System.Data.SQLite;
using Util;

namespace Data
{
    /// <summary>
    /// ユーザー基本情報
    /// </summary>
    [Table("CmnUserInfo")]
    public class CmnUserInfo
    {
        [Column("realname",true,DbType.TEXT)]
        public string Realname { get; set; }

        [Column("Username",true,DbType.TEXT)]
        public string Username { get; set; }

        [Column("Birthday",true,DbType.INT)]
        public DateTime Birthday { get; set; }

        [Column("Sex",true,DbType.TEXT)]
        public Sex UserSex { get; set; }
    }

    /// <summary>
    /// ユーザー身体情報
    /// </summary>
    [Table("BodyUserInfo")]
    public class BodyUserInfo
    {
        [Column("Username",true,DbType.TEXT)]
        public string UserName { get; set; }

        [Column("Weight",true,DbType.REAL)]
        public double Weight { get; set; }

        [Column("Height", true, DbType.REAL)]
        public double Height { get; set; }

        [Column("Bodyfat", false, DbType.REAL)]
        public double Bodyfat { get; set; }
    }

    /// <summary>
    /// ユーザー食事情報
    /// </summary>
    [Table("MealUserInfo")]
    public class MealUserInfo
    {
        [Column("Username", true, DbType.TEXT)]
        public string UserName { get; set; }

        [Column("BaseMetabolism", true, DbType.INT)]
        public int BaseMetabolism { get; set; }

        [Column("ConsumedCalories", true, DbType.INT)]
        public int ConsumedCalories { get; set; }

        [Column("MealPurpose",true,DbType.TEXT)]
        public MealPurpose MealPurpose { get; set; }
    }

    /// <summary>
    /// ユーザートレーニング情報
    /// </summary>
    [Table("TrainingUserInfo")]
    public class TrainingUserInfo
    {
        [Column("Username", true, DbType.TEXT)]
        public string UserName { get; set; }

        [Column("TrainingEvent", true, DbType.TEXT)]
        public string TrainingEvent { get; set; }

        [Column("Weight", true, DbType.REAL)]
        public double Weight { get; set; }

        [Column("Weight", true, DbType.REAL)]
        public int Rep { get; set; }

        [Column("Weight", false, DbType.REAL)]
        public int SetCount { get; set; }

        [Column("Weight", true, DbType.REAL)]
        public DateTime TraingingDay { get; set; }
    }
}
