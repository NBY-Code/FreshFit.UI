using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FreshFit.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BurnedCalory = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivityID);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Calory = table.Column<double>(type: "float", nullable: false),
                    Carbohydrate = table.Column<double>(type: "float", nullable: false),
                    Protein = table.Column<double>(type: "float", nullable: false),
                    Fat = table.Column<double>(type: "float", nullable: false),
                    FoodPictureByte = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    StringPicture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodID);
                });

            migrationBuilder.CreateTable(
                name: "FoodsTypes",
                columns: table => new
                {
                    FoodTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodsTypes", x => x.FoodTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false, defaultValue: new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Local)),
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genders = table.Column<int>(type: "int", nullable: false),
                    FavoriteFood = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserPictureByte = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "FoodTypeFoods",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    FoodTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodTypeFoods", x => new { x.FoodID, x.FoodTypeID });
                    table.ForeignKey(
                        name: "FK_FoodTypeFoods_FoodsTypes_FoodTypeID",
                        column: x => x.FoodTypeID,
                        principalTable: "FoodsTypes",
                        principalColumn: "FoodTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodTypeFoods_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "FoodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodMeals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    MealID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    GainCalory = table.Column<double>(type: "float", nullable: false),
                    GainCarbohydrate = table.Column<double>(type: "float", nullable: false),
                    GainProtein = table.Column<double>(type: "float", nullable: false),
                    GainFat = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMeals", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FoodMeals_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "FoodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodMeals_Meals_MealID",
                        column: x => x.MealID,
                        principalTable: "Meals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodMeals_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserActivities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ActivityID = table.Column<int>(type: "int", nullable: false),
                    LoseCalory = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserActivities_Activities_ActivityID",
                        column: x => x.ActivityID,
                        principalTable: "Activities",
                        principalColumn: "ActivityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserActivities_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Water",
                columns: table => new
                {
                    WaterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Water", x => x.WaterID);
                    table.ForeignKey(
                        name: "FK_Water_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityID", "BurnedCalory", "Name" },
                values: new object[,]
                {
                    { 1, 17.899999999999999, "Yüksek Tempo Kosu" },
                    { 2, 17.899999999999999, "İp Atlama" },
                    { 3, 15.6, "Tekwando" },
                    { 4, 14.9, "Yüzme" },
                    { 5, 12.6, "Yavaş Tempo Koşu" },
                    { 6, 12.1, "Tenis" },
                    { 7, 12.1, "Basketbol" },
                    { 8, 11.4, "Paten Kayma" },
                    { 9, 10.6, "Racketbal" },
                    { 10, 15.0, "Kürek Çekme" },
                    { 11, 12.5, "Futbol" },
                    { 12, 7.4000000000000004, "Ağırlık Kaldırma " },
                    { 13, 12.300000000000001, "Bisiklet Sürme " },
                    { 14, 6.0, "Voleybol " },
                    { 15, 5.0, "Dans Etme " },
                    { 16, 7.0, "Bale " }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "Calory", "Carbohydrate", "Fat", "FoodPictureByte", "Name", "Protein", "StringPicture" },
                values: new object[,]
                {
                    { 1, 48.0, 12.07, 0.81999999999999995, null, "Light Ekmeği", 2.1200000000000001, ".\\resimler\\1.jpg" },
                    { 2, 65.0, 12.07, 0.81999999999999995, null, "Çavdar Ekmeği", 2.1200000000000001, ".\\resimler\\2.jpg" },
                    { 3, 66.0, 10.84, 1.0600000000000001, null, "Tahıllı Ekmek", 3.3399999999999999, ".\\resimler\\3.jpg" },
                    { 4, 62.0, 11.949999999999999, 0.84999999999999998, null, "Kepekli Ekmek", 2.2000000000000002, ".\\resimler\\4.jpg" },
                    { 5, 72.0, 13.619999999999999, 1.0, null, "Beyaz Ekmek", 2.5499999999999998, ".\\resimler\\5.jpg" },
                    { 6, 62.0, 11.449999999999999, 1.3100000000000001, null, "Mısır Ekmeği", 1.0800000000000001, ".\\resimler\\6.jpg" },
                    { 7, 216.0, 40.859999999999999, 3.0, null, "Sandviç Ekmeği (Beyaz)", 7.6500000000000004, ".\\resimler\\7.jpg" },
                    { 8, 198.0, 32.520000000000003, 3.1800000000000002, null, "Sandviç Ekmeği (Tahıllı)", 10.02, ".\\resimler\\8.jpg" },
                    { 9, 434.0, 69.0, 17.0, null, "Simit", 1.0, ".\\resimler\\9.jpg" },
                    { 10, 141.0, 30.280000000000001, 1.3200000000000001, null, "Yulaf Gevreği (Musli)", 4.4800000000000004, ".\\resimler\\10.jpg" },
                    { 11, 101.0, 24.280000000000001, 0.029999999999999999, null, "Sade Mısır Gevreği (Cornﬂakes)", 1.8799999999999999, ".\\resimler\\11.jpg" },
                    { 12, 124.0, 27.399999999999999, 1.1200000000000001, null, "Tam Tahıllı Gevrek", 2.3900000000000001, ".\\resimler\\12.jpg" },
                    { 13, 73.0, 13.4, 1.26, null, "Yulaf Ezmesi", 3.2000000000000002, ".\\resimler\\13.jpg" },
                    { 14, 77.0, 17.489999999999998, 0.089999999999999997, null, "Patates", 2.0499999999999998, ".\\resimler\\14.jpg" },
                    { 15, 110.0, 8.6400000000000006, 5.8499999999999996, null, "İnek Sütü(Tam Yaglı)", 5.6699999999999999, ".\\resimler\\15.jpg" },
                    { 16, 92.0, 10.84, 2.0800000000000001, null, "İnek Sütü (Yarım Yaglı)", 6.6600000000000001, ".\\resimler\\16.jpg" },
                    { 17, 76.0, 10.0, 0.01, null, "İnek Sütü (Yagsız)", 6.6600000000000001, ".\\resimler\\17.jpg" },
                    { 18, 124.0, 10.0, 6.6600000000000001, null, "Keçi Sütü", 6.6600000000000001, ".\\resimler\\18.jpg" },
                    { 19, 112.0, 17.600000000000001, 2.3999999999999999, null, "Soya Sütü", 4.0, ".\\resimler\\19.jpg" },
                    { 20, 200.0, 7.6900000000000004, 18.489999999999998, null, "Hindistan Cevizi Sütü", 1.54, ".\\resimler\\20.jpg" },
                    { 21, 60.0, 2.4399999999999999, 4.5800000000000001, null, "Beyaz Peynir(Yarım Yaglı İnek)", 2.3500000000000001, ".\\resimler\\21.jpg" },
                    { 22, 69.0, 1.05, 5.4000000000000004, null, "Süzme Peynir", 4.0499999999999998, ".\\resimler\\22.jpg" },
                    { 23, 43.0, 0.92000000000000004, 0.20999999999999999, null, "Lor Peyniri	", 8.5999999999999996, ".\\resimler\\23.jpg" },
                    { 24, 75.299999999999997, 1.2, 3.75, null, "Light Kaşar Peyniri", 9.1500000000000004, ".\\resimler\\24.jpg" },
                    { 25, 95.5, 2.25, 8.5, null, "Labne Peyniri", 2.4500000000000002, ".\\resimler\\25.jpg" },
                    { 26, 97.200000000000003, 0.45000000000000001, 7.0499999999999998, null, "Örgü Peynir", 8.0, ".\\resimler\\26.jpg" },
                    { 27, 81.0, 0.59999999999999998, 5.7000000000000002, null, "Dil Peyniri", 6.7800000000000002, ".\\resimler\\27.jpg" },
                    { 28, 90.0, 0.66000000000000003, 6.71, null, "Mozarella", 6.6100000000000003, ".\\resimler\\28.jpg" },
                    { 29, 91.5, 0.25, 6.9000000000000004, null, "Hellim Peyniri", 7.1299999999999999, ".\\resimler\\29.jpg" },
                    { 30, 120.0, 10.0, 6.0, null, "Kefir (Yaglı)", 5.5999999999999996, ".\\resimler\\30.jpg" },
                    { 31, 74.0, 8.0600000000000005, 1.6699999999999999, null, "Kefir (Yagsız)", 6.8200000000000003, ".\\resimler\\31.jpg" },
                    { 32, 156.0, 20.0, 6.0, null, "Meyveli Kefir", 5.4000000000000004, ".\\resimler\\32.jpg" },
                    { 33, 95.0, 4.5, 6.2999999999999998, null, "Süzme Yoğurt", 5.04, ".\\resimler\\33.jpg" },
                    { 34, 87.0, 3.5800000000000001, 4.5, null, "Yoğurt (Yaglı)", 8.0999999999999996, ".\\resimler\\34.jpg" },
                    { 35, 53.0, 3.2400000000000002, 0.34999999999999998, null, "Yoğurt (Yagsız)", 9.1699999999999999, ".\\resimler\\35.jpg" },
                    { 36, 95.0, 11.06, 2.7000000000000002, null, "Meyveli Yoğurt", 6.5999999999999996, ".\\resimler\\36.jpg" },
                    { 37, 76.0, 5.5999999999999996, 4.0, null, "Ayran", 4.0, ".\\resimler\\37.jpg" },
                    { 38, 115.0, 11.0, 4.8600000000000003, null, "Cacık", 6.6600000000000001, ".\\resimler\\38.jpg" },
                    { 39, 48.0, 6.0, 2.2000000000000002, null, "Badem Sütü", 1.0, ".\\resimler\\39.jpg" },
                    { 40, 95.0, 25.129999999999999, 0.31, null, "Elma", 0.46999999999999997, ".\\resimler\\40.jpg" },
                    { 41, 101.0, 27.109999999999999, 0.25, null, "Armut", 0.64000000000000001, ".\\resimler\\41.jpg" },
                    { 42, 62.0, 15.390000000000001, 0.16, null, "Portakal", 1.23, ".\\resimler\\42.jpg" },
                    { 43, 74.0, 18.449999999999999, 0.25, null, "Greyfurt", 1.3500000000000001, ".\\resimler\\43.jpg" },
                    { 44, 57.0, 15.300000000000001, 0.10000000000000001, null, "Ayva", 0.40000000000000002, ".\\resimler\\44.jpg" },
                    { 45, 40.0, 10.140000000000001, 0.23999999999999999, null, "Mandalina", 0.62, ".\\resimler\\45.jpg" },
                    { 46, 42.0, 10.119999999999999, 0.35999999999999999, null, "Kivi", 0.79000000000000004, ".\\resimler\\46.jpg" },
                    { 47, 105.0, 26.949999999999999, 0.39000000000000001, null, "Muz", 1.29, ".\\resimler\\47.jpg" },
                    { 48, 17.0, 3.8900000000000001, 0.14000000000000001, null, "Kayısı", 0.48999999999999999, ".\\resimler\\48.jpg" },
                    { 49, 46.0, 11.06, 0.42999999999999999, null, "Çilek", 0.95999999999999996, ".\\resimler\\49.jpg" },
                    { 50, 60.0, 15.960000000000001, 0.17000000000000001, null, "Trabzon hurması", 0.47999999999999998, ".\\resimler\\50.jpg" },
                    { 51, 87.0, 22.09, 0.28000000000000003, null, "Kiraz", 1.46, ".\\resimler\\51.jpg" },
                    { 52, 52.0, 12.550000000000001, 0.31, null, "Vişne", 1.03, ".\\resimler\\52.jpg" },
                    { 53, 54.0, 13.06, 0.29999999999999999, null, "Kavun", 1.3400000000000001, ".\\resimler\\53.jpg" },
                    { 54, 46.0, 11.630000000000001, 0.23000000000000001, null, "Karpuz", 0.93999999999999995, ".\\resimler\\54.jpg" },
                    { 55, 28.0, 7.3499999999999996, 0.070000000000000007, null, "Ananas", 0.29999999999999999, ".\\resimler\\55.jpg" },
                    { 56, 106.0, 5.6299999999999999, 9.6799999999999997, null, "Avakado", 1.3200000000000001, ".\\resimler\\56.jpg" },
                    { 57, 99.0, 24.719999999999999, 0.63, null, "Mango", 1.3500000000000001, ".\\resimler\\57.jpg" },
                    { 58, 64.0, 14.69, 0.80000000000000004, null, "Ahududu", 1.48, ".\\resimler\\58.jpg" },
                    { 59, 62.0, 13.84, 0.70999999999999996, null, "Böğürtlen", 2.0, ".\\resimler\\59.jpg" },
                    { 60, 84.0, 21.449999999999999, 0.48999999999999999, null, "Yaban Mersini", 1.1000000000000001, ".\\resimler\\60.jpg" },
                    { 61, 76.0, 18.84, 0.46000000000000002, null, "Yeşil Erik", 1.1499999999999999, ".\\resimler\\61.jpg" },
                    { 62, 13.0, 3.02, 0.16, null, "Kumkuat", 0.35999999999999999, ".\\resimler\\62.jpg" },
                    { 63, 81.0, 21.010000000000002, 0.31, null, "Kırmızı Erik", 0.96999999999999997, ".\\resimler\\63.jpg" },
                    { 64, 70.0, 18.09, 0.29999999999999999, null, "Yenidüny", 0.64000000000000001, ".\\resimler\\64.jpg" },
                    { 65, 37.0, 9.5899999999999999, 0.14999999999999999, null, "İncir", 0.38, ".\\resimler\\65.jpg" },
                    { 66, 60.0, 13.720000000000001, 0.55000000000000004, null, "Dut", 2.02, ".\\resimler\\66.jpg" },
                    { 67, 104.0, 27.329999999999998, 0.23999999999999999, null, "Üzüm", 1.0900000000000001, ".\\resimler\\67.jpg" },
                    { 68, 72.0, 16.27, 1.02, null, "Nar", 1.45, ".\\resimler\\68.jpg" },
                    { 69, 58.0, 14.31, 0.38, null, "Şeftali", 1.3600000000000001, ".\\resimler\\69.jpg" },
                    { 70, 17.0, 5.4100000000000001, 0.17000000000000001, null, "Limon", 0.64000000000000001, ".\\resimler\\70.jpg" },
                    { 71, 47.0, 12.140000000000001, 0.17999999999999999, null, "Kuru İncir", 0.63, ".\\resimler\\71.jpg" },
                    { 72, 89.700000000000003, 23.75, 14.0, null, "Kuru üzüm", 0.92000000000000004, ".\\resimler\\72.jpg" },
                    { 73, 16.0, 4.3799999999999999, 0.040000000000000001, null, "Kuru kayısı", 0.23999999999999999, ".\\resimler\\73.jpg" },
                    { 74, 20.0, 5.3700000000000001, 0.029999999999999999, null, "Kuru mürdüm eriği", 0.17999999999999999, ".\\resimler\\74.jpg" },
                    { 75, 91.0, 24.129999999999999, 0.40000000000000002, null, "Kuru yaban mersini", 0.12, ".\\resimler\\75.jpg" },
                    { 76, 23.0, 6.2300000000000004, 0.029999999999999999, null, "Hurma", 0.20000000000000001, ".\\resimler\\76.jpg" },
                    { 77, 67.599999999999994, 16.98, 0.35999999999999999, null, "Kuru dut	", 0.88, ".\\resimler\\77.jpg" },
                    { 78, 124.0, 29.5, 0.0, null, "Taze Sıkılmış Meyve Suyu	", 0.44, ".\\resimler\\78.jpg" },
                    { 79, 22.0, 4.7800000000000002, 0.25, null, "Domates	", 1.0800000000000001, ".\\resimler\\79.jpg" },
                    { 80, 27.0, 5.7999999999999998, 0.29999999999999999, null, "Çeri Domates	", 1.3100000000000001, ".\\resimler\\80.jpg" },
                    { 81, 15.0, 3.6299999999999999, 0.11, null, "Salatalık", 0.65000000000000002, ".\\resimler\\81.jpg" },
                    { 82, 5.0, 1.03, 0.050000000000000003, null, "Marul Kıvırcık", 0.48999999999999999, ".\\resimler\\82.jpg" },
                    { 83, 12.0, 2.46, 0.20999999999999999, null, "Çarliston Biber", 0.76000000000000001, ".\\resimler\\83.jpg" },
                    { 84, 37.0, 7.1799999999999997, 0.35999999999999999, null, "Kırmızı Biber", 1.1799999999999999, ".\\resimler\\84.jpg" },
                    { 85, 1.0, 0.23999999999999999, 0.01, null, "Nane", 0.059999999999999998, ".\\resimler\\85.jpg" },
                    { 86, 1.0, 0.23000000000000001, 0.029999999999999999, null, "Reyhan/Fesleğen", 0.13, ".\\resimler\\86.jpg" },
                    { 87, 1.0, 0.23000000000000001, 0.029999999999999999, null, "Dereotu", 0.13, ".\\resimler\\87.jpg" },
                    { 88, 5.0, 0.98999999999999999, 0.32000000000000001, null, "Kişniş", 0.22, ".\\resimler\\88.jpg" },
                    { 89, 4.0, 0.77000000000000002, 0.17999999999999999, null, "Biberiye", 0.059999999999999998, ".\\resimler\\89.jpg" },
                    { 90, 1.0, 0.23999999999999999, 0.029999999999999999, null, "Maydanoz", 0.11, ".\\resimler\\90.jpg" },
                    { 91, 19.0, 3.9399999999999999, 0.12, null, "Turp", 0.79000000000000004, ".\\resimler\\91.jpg" },
                    { 92, 5.0, 0.72999999999999998, 0.13, null, "Roka", 0.52000000000000002, ".\\resimler\\92.jpg" },
                    { 93, 16.0, 3.0, 0.17000000000000001, null, "Kereviz Yaprağı", 0.69999999999999996, ".\\resimler\\93.jpg" },
                    { 94, 27.0, 5.3200000000000003, 0.29999999999999999, null, "Karnabahar", 2.0499999999999998, ".\\resimler\\94.jpg" },
                    { 95, 31.0, 6.04, 0.34000000000000002, null, "Brokoli", 2.5699999999999998, ".\\resimler\\95.jpg" },
                    { 96, 38.0, 7.8799999999999999, 0.26000000000000001, null, "Brüksel Lahanası", 2.9700000000000002, ".\\resimler\\96.jpg" },
                    { 97, 22.0, 5.1600000000000001, 0.089999999999999997, null, "Beyaz Lahana", 1.1399999999999999, ".\\resimler\\97.jpg" },
                    { 98, 28.0, 6.5599999999999996, 0.14000000000000001, null, "Kırmızı Lahana", 1.27, ".\\resimler\\98.jpg" },
                    { 99, 25.0, 5.8399999999999999, 0.14999999999999999, null, "Havuç", 0.56999999999999995, ".\\resimler\\99.jpg" },
                    { 100, 4.0, 0.98999999999999999, 0.02, null, "Sarımsak", 0.19, ".\\resimler\\100.jpg" },
                    { 101, 44.0, 10.27, 0.11, null, "Soğan", 1.21, ".\\resimler\\101.jpg" },
                    { 102, 2.0, 0.44, 0.01, null, "Yeşil Soğan", 0.11, ".\\resimler\\102.jpg" },
                    { 103, 9.0, 1.46, 0.14999999999999999, null, "Semizotu", 0.87, ".\\resimler\\103.jpg" },
                    { 104, 7.0, 1.3500000000000001, 0.070000000000000007, null, "Pazı", 0.65000000000000002, ".\\resimler\\104.jpg" },
                    { 105, 33.0, 6.0999999999999996, 0.63, null, "Kabak", 2.3700000000000001, ".\\resimler\\105.jpg" },
                    { 106, 98.0, 22.09, 0.62, null, "Kestane (Haşlama veya Izgara)", 0.81000000000000005, ".\\resimler\\106.jpg" },
                    { 107, 76.0, 15.58, 0.83999999999999997, null, "Patlamış Mısır (Yagsız/Tuzsuz)", 2.3999999999999999, ".\\resimler\\107.jpg" },
                    { 108, 71.0, 11.699999999999999, 1.25, null, "Sarı Leblebi", 3.73, ".\\resimler\\108.jpg" },
                    { 109, 72.0, 11.9, 1.2, null, "Beyaz Leblebi", 3.79, ".\\resimler\\109.jpg" },
                    { 110, 97.0, 2.5699999999999998, 9.3599999999999994, null, "Fındık", 2.2999999999999998, ".\\resimler\\110.jpg" },
                    { 111, 97.0, 3.6200000000000001, 8.3900000000000006, null, "Badem", 3.5499999999999998, ".\\resimler\\111.jpg" },
                    { 112, 52.0, 1.1000000000000001, 5.2199999999999998, null, "Ceviz", 1.22, ".\\resimler\\112.jpg" },
                    { 113, 104.40000000000001, 2.6800000000000002, 8.4199999999999999, null, "Kabak Çekirdeği", 6.5999999999999996, ".\\resimler\\113.jpg" },
                    { 114, 111.0, 6.04, 8.7699999999999996, null, "Çiğ Kaju", 3.6400000000000001, ".\\resimler\\114.jpg" },
                    { 115, 32.0, 5.2000000000000002, 0.76000000000000001, null, "Galeta", 0.66000000000000003, ".\\resimler\\115.jpg" },
                    { 116, 22.0, 3.7999999999999998, 0.47999999999999998, null, "Grissini", 0.52000000000000002, ".\\resimler\\116.jpg" },
                    { 117, 22.0, 3.7999999999999998, 0.47999999999999998, null, "Grissini(ince)", 0.52000000000000002, ".\\resimler\\117.jpg" },
                    { 118, 59.0, 2.3999999999999999, 2.7000000000000002, null, "Köfte", 6.2999999999999998, ".\\resimler\\118.jpg" },
                    { 119, 75.599999999999994, 0.0, 4.5, null, "Biftek", 8.1999999999999993, ".\\resimler\\119.jpg" },
                    { 120, 82.0, 0.0, 4.0999999999999996, null, "Dana Antrikot", 10.73, ".\\resimler\\120.jpg" },
                    { 121, 65.099999999999994, 0.0, 3.7000000000000002, null, "Dana Kuşbaşı", 7.4400000000000004, ".\\resimler\\121.jpg" },
                    { 122, 70.0, 0.02, 3.3300000000000001, null, "Yagsız Koyun Eti", 10.029999999999999, ".\\resimler\\122.jpg" },
                    { 123, 68.0, 0.0, 2.77, null, "Tavşan", 10.029999999999999, ".\\resimler\\123.jpg" },
                    { 124, 63.0, 0.0, 1.73, null, "Hindi (Göğüs)", 11.08, ".\\resimler\\124.jpg" },
                    { 125, 62.0, 0.0, 2.9500000000000002, null, "Hindi (But)", 8.3599999999999994, ".\\resimler\\125.jpg" },
                    { 126, 76.0, 0.0, 1.5800000000000001, null, "Tavuk (Göğüs)", 15.27, ".\\resimler\\126.jpg" },
                    { 127, 66.0, 0.0, 3.8799999999999999, null, "Tavuk (But)", 7.25, ".\\resimler\\127.jpg" },
                    { 128, 61.0, 0.0, 2.4399999999999999, null, "Tavuk (Kanat)", 9.1400000000000006, ".\\resimler\\128.jpg" },
                    { 129, 70.0, 0.5, 4.7699999999999996, null, "Yumurta (Haşlanmış)", 5.6600000000000001, ".\\resimler\\129.jpg" },
                    { 130, 76.0, 0.0, 2.6400000000000001, null, "Somon", 12.289999999999999, ".\\resimler\\130.jpg" },
                    { 131, 103.0, 0.0, 3.6299999999999999, null, "Somon (Füme)", 17.59, ".\\resimler\\131.jpg" },
                    { 132, 86.0, 0.0, 0.95999999999999996, null, "Light Ton Balığı", 19.440000000000001, ".\\resimler\\132.jpg" },
                    { 133, 119.0, 0.0, 5.2400000000000002, null, "Alabalık", 16.899999999999999, ".\\resimler\\133.jpg" },
                    { 134, 129.0, 0.0, 1.25, null, "Istakoz", 27.550000000000001, ".\\resimler\\134.jpg" },
                    { 135, 125.0, 0.0, 2.5899999999999999, null, "Levrek", 23.870000000000001, ".\\resimler\\135.jpg" },
                    { 136, 120.0, 0.0, 3.0, null, "Çupra", 21.710000000000001, ".\\resimler\\136.jpg" },
                    { 137, 128.0, 0.0, 1.74, null, "Karides", 26.140000000000001, ".\\resimler\\137.jpg" },
                    { 138, 138.0, 0.0, 6.0899999999999999, null, "Sazan", 19.43, ".\\resimler\\138.jpg" },
                    { 139, 99.0, 0.0, 1.4399999999999999, null, "Mezgit	", 19.960000000000001, ".\\resimler\\139.jpg" },
                    { 140, 156.0, 0.0, 5.3399999999999999, null, "İstavrit	", 25.420000000000002, ".\\resimler\\140.jpg" },
                    { 141, 42.0, 0.0, 1.9399999999999999, null, "Hamsi	", 5.7800000000000002, ".\\resimler\\141.jpg" },
                    { 142, 231.0, 0.0, 15.67, null, "Palamut", 20.989999999999998, ".\\resimler\\142.jpg" },
                    { 143, 128.0, 0.0, 4.1299999999999999, null, "Barbun", 21.09, ".\\resimler\\143.jpg" },
                    { 144, 104.0, 0.0, 3.21, null, "Kalkan", 17.489999999999998, ".\\resimler\\144.jpg" },
                    { 145, 82.0, 0.0, 1.6599999999999999, null, "Fener", 15.779999999999999, ".\\resimler\\145.jpg" },
                    { 146, 139.0, 0.0, 1.77, null, "Ahtapot", 25.350000000000001, ".\\resimler\\146.jpg" },
                    { 147, 73.0, 0.0, 2.0099999999999998, null, "Dil Balığı", 12.949999999999999, ".\\resimler\\147.jpg" },
                    { 148, 99.0, 9.6300000000000008, 5.2000000000000002, null, "Mercimek Çorbası", 3.6099999999999999, ".\\resimler\\148.jpg" },
                    { 149, 56.0, 7.0, 1.8300000000000001, null, "Tavuk Çorbası", 3.02, ".\\resimler\\149.jpg" },
                    { 150, 147.59999999999999, 26.5, 2.52, null, "Tarhana Çorbası", 4.4100000000000001, ".\\resimler\\150.jpg" },
                    { 151, 59.0, 10.91, 0.81000000000000005, null, "Sebze Çorbası", 1.98, ".\\resimler\\151.jpg" },
                    { 152, 93.599999999999994, 16.829999999999998, 0.29999999999999999, null, "Ezogelin Çorbası", 6.21, ".\\resimler\\152.jpg" },
                    { 153, 117.0, 9.4299999999999997, 7.3799999999999999, null, "Yayla Çorbası", 3.29, ".\\resimler\\153.jpg" },
                    { 154, 53.0, 8.0999999999999996, 1.8300000000000001, null, "Balkabağı Çorbası", 1.8500000000000001, ".\\resimler\\154.jpg" },
                    { 155, 123.0, 10.32, 7.1500000000000004, null, "Mantar çorbası", 4.4000000000000004, ".\\resimler\\155.jpg" },
                    { 156, 156.0, 13.6, 9.0299999999999994, null, "Brokoli Çorbası", 6.1900000000000004, ".\\resimler\\156.jpg" },
                    { 157, 53.0, 5.6500000000000004, 2.3900000000000001, null, "Lahana Çorbası", 2.8799999999999999, ".\\resimler\\157.jpg" },
                    { 158, 68.0, 12.91, 1.1000000000000001, null, "Domates Çorbası", 1.6699999999999999, ".\\resimler\\158.jpg" },
                    { 159, 9.0, 1.76, 0.13, null, "Sade Salata(karışık yeşillik)", 0.83999999999999997, ".\\resimler\\159.jpg" },
                    { 160, 180.0, 28.0, 5.0999999999999996, null, "Mercimekli Lor Peynirli Salata", 2.7000000000000002, ".\\resimler\\160.jpg" },
                    { 161, 225.0, 5.2800000000000002, 8.2899999999999991, null, "Tavuklu Salata", 31.379999999999999, ".\\resimler\\161.jpg" },
                    { 162, 267.0, 5.2800000000000002, 16.489999999999998, null, "Etli Salata", 24.84, ".\\resimler\\162.jpg" },
                    { 163, 215.0, 5.2800000000000002, 6.3499999999999996, null, "Ton Balıklı Salata", 21.960000000000001, ".\\resimler\\163.jpg" },
                    { 164, 108.0, 15.84, 4.6399999999999997, null, "Kısır	", 2.71, ".\\resimler\\164.jpg" },
                    { 165, 70.0, 9.9499999999999993, 2.4100000000000001, null, "Mercimek Köftesi", 2.75, ".\\resimler\\165.jpg" },
                    { 166, 588.0, 51.0, 33.299999999999997, null, "Tabule Salatası", 14.4, ".\\resimler\\166.jpg" },
                    { 167, 225.0, 6.7000000000000002, 9.8100000000000005, null, "Lor Peynirli Yumurtalı Salata	", 16.780000000000001, ".\\resimler\\167.jpg" },
                    { 168, 115.0, 5.0899999999999999, 10.300000000000001, null, "Ispanak Yemeği (Pirinçli veya Bulgurlu)", 2.1099999999999999, ".\\resimler\\168.jpg" },
                    { 169, 144.5, 6.29, 11.65, null, "Ispanak Yemeği (Etli,Kıymalı,Yumurtalı)", 5.2599999999999998, ".\\resimler\\169.jpg" },
                    { 170, 112.0, 4.9800000000000004, 10.26, null, "ZeytinYaglı Semizotu (Pirinçli veya Bulgurlu)", 1.29, ".\\resimler\\170.jpg" },
                    { 171, 141.5, 6.1799999999999997, 11.0, null, "Semizotu Yemeği (Etli veya Kıymalı)", 4.4400000000000004, ".\\resimler\\171.jpg" },
                    { 172, 131.0, 11.890000000000001, 7.1799999999999997, null, "ZeytinYaglı Pazı (Pirinçli veya Bulgurlu)", 3.7400000000000002, ".\\resimler\\172.jpg" },
                    { 173, 160.0, 13.09, 8.5299999999999994, null, "Pazı Yemeği (Etli veya Kıymalı)", 6.8899999999999997, ".\\resimler\\173.jpg" },
                    { 174, 151.0, 21.390000000000001, 5.1500000000000004, null, "ZeytinYaglı Taze Fasülye", 5.54, ".\\resimler\\174.jpg" },
                    { 175, 180.5, 22.59, 6.5, null, "Taze Fasulye Yemeği (Etli veya Kıymalı)", 8.6899999999999995, ".\\resimler\\175.jpg" },
                    { 176, 120.0, 7.25, 10.27, null, "ZeytinYaglı Pırasa(Pirinçli ya da Nohutlu)", 0.91000000000000003, ".\\resimler\\176.jpg" },
                    { 177, 147.0, 11.07, 10.380000000000001, null, "Bezelye Yemeği (Havuçlu)", 3.48, ".\\resimler\\177.jpg" },
                    { 178, 176.5, 12.27, 11.73, null, "Bezelye Yemeği (Etli/Tavuklu/Kıymalı)", 6.6299999999999999, "\\resimler.\\178.jpg" },
                    { 179, 80.0, 7.1399999999999997, 5.4100000000000001, null, "ZeytinYaglı Brokoli", 2.3700000000000001, ".\\resimler\\179.jpg" },
                    { 180, 110.0, 8.3399999999999999, 6.7599999999999998, null, "Brokoli Yemeği (Etli/Kıymalı)", 5.5199999999999996, ".\\resimler\\180.jpg" },
                    { 181, 115.0, 5.29, 10.41, null, "Karnabahar Yemeği", 1.48, ".\\resimler\\181.jpg" },
                    { 182, 144.5, 6.4500000000000002, 11.76, null, "Karnabahar Yemeği (Etli/Tavuklu/Kıymalı)", 4.6299999999999999, ".\\resimler\\182.jpg" },
                    { 183, 113.0, 4.6799999999999997, 10.57, null, "Bamya Yemeği", 1.0600000000000001, ".\\resimler\\183.jpg" },
                    { 184, 142.5, 5.8799999999999999, 11.92, null, "Bamya Yemeği (Etli/Kıymalı)", 4.21, ".\\resimler\\184.jpg" },
                    { 185, 112.0, 8.6799999999999997, 8.8699999999999992, null, "ZeytinYaglı Türlü", 1.3300000000000001, ".\\resimler\\185.jpg" },
                    { 186, 141.5, 9.8800000000000008, 10.220000000000001, null, "Etli Türlü Yemeği", 4.4800000000000004, ".\\resimler\\186.jpg" },
                    { 187, 145.0, 9.7599999999999998, 10.69, null, "ZeytinYaglı Bakla", 3.3199999999999998, ".\\resimler\\187.jpg" },
                    { 188, 90.0, 7.1399999999999997, 6.3700000000000001, null, "ZeytinYaglı Kereviz", 1.9199999999999999, ".\\resimler\\188.jpg" },
                    { 189, 146.0, 12.09, 10.710000000000001, null, "ZeytinYaglı Enginar", 2.9300000000000002, ".\\resimler\\189.jpg" },
                    { 190, 118.0, 5.9500000000000002, 10.42, null, "Mantar sote (Etli/Tavuklu)	", 1.6699999999999999, ".\\resimler\\190.jpg" },
                    { 191, 90.0, 4.5499999999999998, 10.19, null, "Sebze Sote (Havuç,Yeşil kabak,brokoli)", 0.93999999999999995, ".\\resimler\\191.jpg" },
                    { 192, 258.0, 13.59, 13.59, null, "ZeytinYaglı Sebze Dolması", 5.5999999999999996, ".\\resimler\\192.jpg" },
                    { 193, 108.0, 8.3200000000000003, 8.1500000000000004, null, "ZeytinYaglı yaprak Sarma", 1.3300000000000001, ".\\resimler\\193.jpg" },
                    { 194, 358.0, 8.3000000000000007, 28.170000000000002, null, "Etli Sebze Dolması", 18.670000000000002, ".\\resimler\\194.jpg" },
                    { 195, 176.0, 11.24, 12.32, null, "Etli Yaprak Sarma", 6.2300000000000004, ".\\resimler\\195.jpg" },
                    { 196, 111.0, 5.1900000000000004, 10.18, null, "ZeytinYaglı Kabak", 0.81000000000000005, ".\\resimler\\196.jpg" },
                    { 197, 140.5, 6.3899999999999997, 11.529999999999999, null, "Kabak Yemeği(Etli/Kıymalı)", 3.96, ".\\resimler\\197.jpg" },
                    { 198, 15.0, 2.6899999999999999, 0.35999999999999999, null, "Yeşil Kabak", 1.1399999999999999, ".\\resimler\\198.jpg" },
                    { 199, 7.0, 1.0900000000000001, 0.12, null, "Ispanak", 0.85999999999999999, ".\\resimler\\199.jpg" },
                    { 200, 7.0, 1.47, 0.040000000000000001, null, "Semizotu", 0.56000000000000005, ".\\resimler\\200.jpg" },
                    { 201, 39.0, 7.8899999999999997, 0.28000000000000003, null, "Pazı", 3.7000000000000002, ".\\resimler\\201.jpg" },
                    { 202, 29.0, 5.0999999999999996, 0.56000000000000005, null, "Karnabahar", 2.2799999999999998, ".\\resimler\\202.jpg" },
                    { 203, 55.0, 11.199999999999999, 0.64000000000000001, null, "Brokoli", 3.71, ".\\resimler\\203.jpg" },
                    { 204, 56.0, 11.08, 0.78000000000000003, null, "Brüksel Lahanası", 3.98, ".\\resimler\\204.jpg" },
                    { 205, 44.0, 9.8499999999999996, 0.34999999999999998, null, "Taze Fasülye", 2.3599999999999999, ".\\resimler\\205.jpg" },
                    { 206, 55.0, 12.82, 0.28000000000000003, null, "Havuç", 1.1899999999999999, ".\\resimler\\206.jpg" },
                    { 207, 254.0, 2.0499999999999998, 14.9, null, "Peynirli omlet", 15.369999999999999, ".\\resimler\\207.jpg" },
                    { 208, 205.0, 3.6899999999999999, 9.9000000000000004, null, "Mantarlı omlet", 12.460000000000001, ".\\resimler\\208.jpg" },
                    { 209, 205.0, 3.6899999999999999, 9.9000000000000004, null, "Menemen	", 12.460000000000001, ".\\resimler\\209.jpg" },
                    { 210, 260.30000000000001, 2.2000000000000002, 13.289999999999999, null, "Kaşarlı omlet", 20.27, ".\\resimler\\210.jpg" },
                    { 211, 205.0, 3.6899999999999999, 9.9000000000000004, null, "Sebzeli omlet", 12.460000000000001, ".\\resimler\\211.jpg" },
                    { 212, 258.0, 14.4, 10.800000000000001, null, "Yulaﬂı omlet", 14.52, ".\\resimler\\212.jpg" },
                    { 213, 185.0, 1.0, 14.9, null, "Omlet Sade", 11.32, ".\\resimler\\213.jpg" },
                    { 214, 100.2, 8.5399999999999991, 6.2199999999999998, null, "Mercimek Yemeği", 3.29, ".\\resimler\\214.jpg" },
                    { 215, 160.0, 10.94, 8.9199999999999999, null, "Mercimek Yemeği(Etli/Kıymalı)", 9.5899999999999999, ".\\resimler\\215.jpg" },
                    { 216, 101.40000000000001, 9.3699999999999992, 6.4699999999999998, null, "Nohut Yemeği", 1.9299999999999999, ".\\resimler\\216.jpg" },
                    { 217, 160.40000000000001, 11.77, 9.1699999999999999, null, "Nohut Yemeği(Etli/Kıymalı)", 8.2300000000000004, ".\\resimler\\217.jpg" },
                    { 218, 101.40000000000001, 9.3699999999999992, 6.4699999999999998, null, "Kuru Fasülye Yemeği", 1.9299999999999999, ".\\resimler\\218.jpg" },
                    { 219, 160.40000000000001, 11.77, 9.1699999999999999, null, "Kuru Fasülye Yemeği (Etli/Kıymalı)", 8.2300000000000004, ".\\resimler\\219.jpg" },
                    { 220, 80.0, 13.43, 1.5700000000000001, null, "Bulgur Pilavı", 2.2000000000000002, ".\\resimler\\220.jpg" },
                    { 221, 108.0, 18.93, 2.0699999999999998, null, "Bulgur Pilavı (Sebzeli)", 3.25, ".\\resimler\\221.jpg" },
                    { 222, 75.0, 12.94, 1.9399999999999999, null, "Pirinç Pilavı", 1.24, ".\\resimler\\222.jpg" },
                    { 223, 103.0, 18.440000000000001, 2.4399999999999999, null, "Pirinç Pilavı(Sebzeli)", 2.29, ".\\resimler\\223.jpg" },
                    { 224, 77.400000000000006, 14.67, 1.96, null, "Şehriye Pilavı", 0.20000000000000001, ".\\resimler\\224.jpg" },
                    { 225, 74.400000000000006, 15.07, 0.57999999999999996, null, "Makarna (Haşlama ve Yagsız)", 2.6200000000000001, ".\\resimler\\225.jpg" },
                    { 226, 133.40000000000001, 17.469999999999999, 3.2799999999999998, null, "Makarna (Kıymalı)", 8.9199999999999999, ".\\resimler\\226.jpg" },
                    { 227, 117.40000000000001, 15.99, 0.79000000000000004, null, "Makarna(Peynirli)", 11.220000000000001, ".\\resimler\\227.jpg" },
                    { 228, 101.40000000000001, 9.3699999999999992, 6.4699999999999998, null, "ZeytinYaglı Barbunya", 1.9299999999999999, ".\\resimler\\228.jpg" },
                    { 229, 45.0, 0.0, 5.0, null, "ZeytinYagı", 0.0, ".\\resimler\\229.jpg" },
                    { 230, 45.0, 0.0, 5.0, null, "Fındık Yagı", 0.0, ".\\resimler\\230.jpg" },
                    { 231, 45.0, 0.0, 5.0, null, "Ceviz Yagı", 0.0, ".\\resimler\\231.jpg" },
                    { 232, 36.0, 0.0, 4.0599999999999996, null, "TereYag", 0.040000000000000001, ".\\resimler\\232.jpg" },
                    { 233, 45.0, 2.48, 4.2300000000000004, null, "Zeytin (Yeşil/Siyah)", 0.33000000000000002, ".\\resimler\\233.jpg" }
                });

            migrationBuilder.InsertData(
                table: "FoodsTypes",
                columns: new[] { "FoodTypeID", "Name" },
                values: new object[,]
                {
                    { 1, "Tahıl ve Ekmek Urunleri" },
                    { 2, "Sut ve Sut Urunleri" },
                    { 3, "Meyveler" },
                    { 4, "Corbalar" },
                    { 5, "Cig Sebzeler" },
                    { 6, "Yaglı Tohumlar ve Atıştırmalıklar" },
                    { 7, "Salatalar" },
                    { 8, "Yaglar" },
                    { 9, "Et ürünleri" },
                    { 10, "Kümes Hayvanları" },
                    { 11, "Deniz Ürünleri" },
                    { 12, "Sebze Yemekleri" },
                    { 13, "Buharda veya Haslama Olarak Tuketilecek Sebzeler" },
                    { 14, "Kahvaltılıklar" },
                    { 15, "Tahıl ve Kuru Baklagil Yemekleri" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, 0 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "FoodTypeFoods",
                columns: new[] { "FoodID", "FoodTypeID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 },
                    { 11, 1 },
                    { 12, 1 },
                    { 13, 1 },
                    { 14, 1 },
                    { 15, 2 },
                    { 16, 2 },
                    { 17, 2 },
                    { 18, 2 },
                    { 19, 2 },
                    { 20, 2 },
                    { 21, 2 },
                    { 22, 2 },
                    { 23, 2 },
                    { 24, 2 },
                    { 25, 2 },
                    { 26, 2 },
                    { 27, 2 },
                    { 28, 2 },
                    { 29, 2 },
                    { 30, 2 },
                    { 31, 2 },
                    { 32, 2 },
                    { 33, 2 },
                    { 34, 2 },
                    { 35, 2 },
                    { 36, 2 },
                    { 37, 2 },
                    { 38, 2 },
                    { 39, 2 },
                    { 40, 3 },
                    { 41, 3 },
                    { 42, 3 },
                    { 43, 3 },
                    { 44, 3 },
                    { 45, 3 },
                    { 46, 3 },
                    { 47, 3 },
                    { 48, 3 },
                    { 49, 3 },
                    { 50, 3 },
                    { 51, 3 },
                    { 52, 3 },
                    { 53, 3 },
                    { 54, 3 },
                    { 55, 3 },
                    { 56, 3 },
                    { 57, 3 },
                    { 58, 3 },
                    { 59, 3 },
                    { 60, 3 },
                    { 61, 3 },
                    { 62, 3 },
                    { 63, 3 },
                    { 64, 3 },
                    { 65, 3 },
                    { 66, 3 },
                    { 67, 3 },
                    { 68, 3 },
                    { 69, 3 },
                    { 70, 3 },
                    { 71, 3 },
                    { 72, 3 },
                    { 73, 3 },
                    { 74, 3 },
                    { 75, 3 },
                    { 76, 3 },
                    { 77, 3 },
                    { 78, 3 },
                    { 79, 4 },
                    { 80, 4 },
                    { 81, 4 },
                    { 82, 4 },
                    { 83, 4 },
                    { 84, 4 },
                    { 85, 4 },
                    { 86, 4 },
                    { 87, 4 },
                    { 88, 4 },
                    { 89, 4 },
                    { 90, 4 },
                    { 91, 4 },
                    { 92, 4 },
                    { 93, 4 },
                    { 94, 4 },
                    { 95, 4 },
                    { 96, 4 },
                    { 97, 4 },
                    { 98, 4 },
                    { 99, 4 },
                    { 100, 4 },
                    { 101, 4 },
                    { 102, 4 },
                    { 103, 4 },
                    { 104, 4 },
                    { 105, 4 },
                    { 106, 5 },
                    { 107, 5 },
                    { 108, 5 },
                    { 109, 5 },
                    { 110, 5 },
                    { 111, 5 },
                    { 112, 5 },
                    { 113, 5 },
                    { 114, 5 },
                    { 115, 5 },
                    { 116, 5 },
                    { 117, 5 },
                    { 118, 7 },
                    { 119, 7 },
                    { 120, 7 },
                    { 121, 7 },
                    { 122, 7 },
                    { 123, 8 },
                    { 124, 8 },
                    { 125, 8 },
                    { 126, 8 },
                    { 127, 8 },
                    { 128, 8 },
                    { 129, 8 },
                    { 130, 9 },
                    { 131, 9 },
                    { 132, 9 },
                    { 133, 9 },
                    { 134, 9 },
                    { 135, 9 },
                    { 136, 9 },
                    { 137, 9 },
                    { 138, 9 },
                    { 139, 9 },
                    { 140, 9 },
                    { 141, 9 },
                    { 142, 9 },
                    { 143, 9 },
                    { 144, 9 },
                    { 145, 9 },
                    { 146, 9 },
                    { 147, 9 },
                    { 148, 10 },
                    { 149, 10 },
                    { 150, 10 },
                    { 151, 10 },
                    { 152, 10 },
                    { 153, 10 },
                    { 154, 10 },
                    { 155, 10 },
                    { 156, 10 },
                    { 157, 10 },
                    { 158, 10 },
                    { 159, 11 },
                    { 160, 11 },
                    { 161, 11 },
                    { 162, 11 },
                    { 163, 11 },
                    { 164, 11 },
                    { 165, 11 },
                    { 166, 11 },
                    { 167, 11 },
                    { 168, 12 },
                    { 169, 12 },
                    { 170, 12 },
                    { 171, 12 },
                    { 172, 12 },
                    { 173, 12 },
                    { 174, 12 },
                    { 175, 12 },
                    { 176, 12 },
                    { 177, 12 },
                    { 178, 12 },
                    { 179, 12 },
                    { 180, 12 },
                    { 181, 12 },
                    { 182, 12 },
                    { 183, 12 },
                    { 184, 12 },
                    { 185, 12 },
                    { 186, 12 },
                    { 187, 12 },
                    { 188, 12 },
                    { 189, 12 },
                    { 190, 12 },
                    { 191, 12 },
                    { 192, 12 },
                    { 193, 12 },
                    { 194, 12 },
                    { 195, 12 },
                    { 196, 12 },
                    { 197, 12 },
                    { 198, 13 },
                    { 199, 13 },
                    { 200, 13 },
                    { 201, 13 },
                    { 202, 13 },
                    { 203, 13 },
                    { 204, 13 },
                    { 205, 13 },
                    { 206, 13 },
                    { 207, 14 },
                    { 208, 14 },
                    { 209, 14 },
                    { 210, 14 },
                    { 211, 14 },
                    { 212, 14 },
                    { 213, 14 },
                    { 214, 15 },
                    { 215, 15 },
                    { 216, 15 },
                    { 217, 15 },
                    { 218, 15 },
                    { 219, 15 },
                    { 220, 15 },
                    { 221, 15 },
                    { 222, 15 },
                    { 223, 15 },
                    { 224, 15 },
                    { 225, 15 },
                    { 226, 15 },
                    { 227, 15 },
                    { 228, 15 },
                    { 229, 6 },
                    { 230, 6 },
                    { 231, 6 },
                    { 232, 6 },
                    { 233, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodMeals_FoodID",
                table: "FoodMeals",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodMeals_MealID",
                table: "FoodMeals",
                column: "MealID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodMeals_UserID",
                table: "FoodMeals",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodTypeFoods_FoodTypeID",
                table: "FoodTypeFoods",
                column: "FoodTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivities_ActivityID",
                table: "UserActivities",
                column: "ActivityID");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivities_UserID",
                table: "UserActivities",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Mail",
                table: "Users",
                column: "Mail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Water_UserID",
                table: "Water",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodMeals");

            migrationBuilder.DropTable(
                name: "FoodTypeFoods");

            migrationBuilder.DropTable(
                name: "UserActivities");

            migrationBuilder.DropTable(
                name: "Water");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "FoodsTypes");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
