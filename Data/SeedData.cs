using System.Collections.Generic;
using System.Linq;
using lab05.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


public static class SampleData {

    public static void Seed(this ModelBuilder modelBuilder){
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );

        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }

    public static List<Province> GetProvinces() {
        List<Province> Provinces = new List<Province>() {
            new Province {
                ProvinceCode= "BC",
                ProvinceName = "British Columbia",
                // Cities= context.Cities.Find("BC").Province
            },
            new Province {
                ProvinceCode= "ON",
                ProvinceName = "Ontario",
                // Cities= context.Cities.Find("ON").Province
            },
            new Province {
               ProvinceCode= "QC",
                ProvinceName = "Quebec",
                // Cities= context.Cities.Find("QC").Province
            }
        };

        return Provinces;
    }

    public static List<City> GetCities() {
        List<City> Cities = new List<City>() {
            new City() {
                CityId= 1,
                CityName="Surrey",
                Population=300000,
                Province= "BC"
            },
            new City() {
                CityId= 2,
                CityName="Vancouver",
                Population=675218,
                Province="BC"
            },
            new City() {
                CityId= 3,
                CityName="Victoria",
                Population=92141,
                Province="BC"
            },
            new City(){
                CityId= 4,
                CityName="Kelowna",
                Population=132084,
                Province="BC"
            },
            // ON
            new City(){
                CityId= 5,
                CityName="Toronto",
                Population=3000000,
                Province="ON"
            },
            new City(){
                CityId= 6,
                CityName="Hamilton",
                Population=500000,
                Province="ON"
            },
            new City(){
                CityId= 7,
                CityName="Ottawa",
                Population=880000,
                Province="ON"
            },
            // QC
            new City(){
                CityId= 8,
                CityName="Montreal",
                Population=2000000,
                Province="QC"
            },
            new City(){
                CityId= 9,
                CityName="Québec City",
                Population=520000,
                Province="QC"
            },
            new City(){
                CityId= 10,
                CityName="Sherbrooke",
                Population=170000,
                Province="QC"
            },
        };

        return Cities;
    }

    
}
