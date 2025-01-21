using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using NovaPoshta.Data.Entities;
using NovaPoshta.Data;
using NovaPoshta.Models.Area;
using NovaPoshta.Models.Cities;
using NovaPoshta.Models.Warehouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NovaPoshta
{
    public class NovaPoshtaService
    {
        private readonly HttpClient _httpClient;
        private readonly string _url;
        private readonly DataBaseContext _context;

        public NovaPoshtaService()
        {
            _httpClient = new HttpClient();
            _url = "https://api.novaposhta.ua/v2.0/json/";
            _context = new DataBaseContext();
            _context.Database.Migrate();
        }

        public void SeedAreas()
        {
            if (!_context.Areas.Any())
            {
                var modelRequest = new AreaPostModel
                {
                    ApiKey = "3740308be13fc7617cb6397c9f44a83d",
                    ModelName = "Address",
                    CalledMethod = "getAreas",
                    MethodProperties = new MethodProperties() { }
                };

                string json = JsonConvert.SerializeObject(modelRequest, new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    Formatting = Formatting.Indented
                });


                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = _httpClient.PostAsync(_url, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    string jsonResp = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject<AreaResponse>(jsonResp);

                    if (result != null && result.Success && result.Data != null)
                    {
                        foreach (var item in result.Data)
                        {
                            var entity = new AreaEntity
                            {
                                Ref = item.Ref,
                                AreasCenter = item.AreasCenter,
                                Description = item.Description
                            };
                            _context.Areas.Add(entity);
                            _context.SaveChanges();
                        }
                    }
                }
            }
        }
        public void SeedCities()
        {
            if (_context.Areas.Any() && !_context.Cities.Any())
            {
                foreach (var area in _context.Areas.ToList())
                {
                    var modelRequest = new CityPostModel
                    {
                        ApiKey = "3740308be13fc7617cb6397c9f44a83d",
                        ModelName = "Address",
                        CalledMethod = "getCities",
                        MethodProperties = new CityMethodProperties() { AreaRef = area.Ref }
                    };

                    string json = JsonConvert.SerializeObject(modelRequest, new JsonSerializerSettings
                    {
                        Formatting = Formatting.Indented
                    });


                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = _httpClient.PostAsync(_url, content).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResp = response.Content.ReadAsStringAsync().Result;
                        var result = JsonConvert.DeserializeObject<CityResponse>(jsonResp);

                        if (result != null && result.Success && result.Data != null)
                        {
                            foreach (var item in result.Data)
                            {
                                if (item.SettlementTypeDescription == "місто")
                                {
                                    var entity = new CityEntity
                                    {
                                        Ref = item.Ref,
                                        Description = item.Description,
                                        Delivery1 = item.Delivery1,
                                        Delivery2 = item.Delivery2,
                                        Delivery3 = item.Delivery3,
                                        Delivery4 = item.Delivery4,
                                        Delivery5 = item.Delivery5,
                                        Delivery6 = item.Delivery6,
                                        Delivery7 = item.Delivery7,
                                        AreaDescription = item.AreaDescription,
                                        CityID = item.CityID,
                                        SettlementTypeDescription = item.SettlementTypeDescription,
                                        Area = item.Area,
                                        IsBranch = item.IsBranch,
                                        PreventEntryNewStreetsUser = item.PreventEntryNewStreetsUser,
                                        SettlementType = item.SettlementType,
                                        SpecialCashCheck = item.SpecialCashCheck,
                                        AreaEntityId = area.Id
                                    };

                                    _context.Cities.Add(entity);
                                    _context.SaveChanges();
                                    var list = GetListCities();
                                }
                            }
                        }
                    }
                }
            }
        }
        public void SeedWarehouses()
        {
            if (_context.Areas.Any() && _context.Cities.Any() && !_context.Warehouses.Any())
            {
                foreach (var city in _context.Cities)
                {
                    var modelRequest = new WarehousePostModel
                    {
                        ApiKey = "3740308be13fc7617cb6397c9f44a83d",
                        ModelName = "Address",
                        CalledMethod = "getWarehouses",
                        MethodProperties = new WarehouseMethodProperties() { CityRef = city.Ref }
                    };

                    var list1 = GetListCities();

                    string json = JsonConvert.SerializeObject(modelRequest, new JsonSerializerSettings
                    {
                        Formatting = Formatting.Indented
                    });


                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = _httpClient.PostAsync(_url, content).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResp = response.Content.ReadAsStringAsync().Result;
                        var result = JsonConvert.DeserializeObject<WarehouseResponse>(jsonResp);

                        if (result != null && result.Success && result.Data != null)
                        {
                            foreach (var item in result.Data)
                            {
                                if (item.SettlementTypeDescription == "місто")
                                {
                                    var entity = new WarehouseEntity
                                    {
                                        Ref = item.Ref,
                                        Description = item.Description,
                                        HasFittingRoom = item.HasFittingRoom,
                                        HasMirror = item.HasMirror,
                                        GeneratorEnabled = item.GeneratorEnabled,
                                        PostFinance = item.PostFinance,
                                        CanGetMoneyTransfer = item.CanGetMoneyTransfer,
                                        BeaconCode = item.BeaconCode,
                                        PaymentAccess = item.PaymentAccess,
                                        BicycleParking = item.BicycleParking,
                                        DenyToSelect = item.DenyToSelect,
                                        CategoryOfWarehouse = item.CategoryOfWarehouse,
                                        PostomatFor = item.PostomatFor,
                                        WarehouseForAgent = item.WarehouseForAgent,
                                        CityDescription = item.CityDescription,
                                        CityRef = item.CityRef,
                                        Direct = item.Direct,
                                        DistrictCode = item.DistrictCode,
                                        InternationalShipping = item.InternationalShipping,
                                        Latitude = item.Latitude,
                                        Location = item.Location,
                                        Longitude = item.Longitude,
                                        MaxDeclaredCost = item.MaxDeclaredCost,
                                        Number = item.Number,
                                        OnlyReceivingParcel = item.OnlyReceivingParcel,
                                        Phone = item.Phone,
                                        PlaceMaxWeightAllowed = item.PlaceMaxWeightAllowed,
                                        PostalCodeUA = item.PostalCodeUA,
                                        POSTerminal = item.POSTerminal,
                                        PostMachineType = item.PostMachineType,
                                        SelfServiceWorkplacesCount = item.SelfServiceWorkplacesCount,
                                        SiteKey = item.SiteKey,
                                        RegionCity = item.RegionCity,
                                        SettlementAreaDescription = item.SettlementAreaDescription,
                                        SettlementDescription = item.SettlementDescription,
                                        SettlementRef = item.SettlementRef,
                                        SettlementTypeDescription = item.SettlementTypeDescription,
                                        ShortAddress = item.ShortAddress,
                                        SettlementRegionsDescription = item.SettlementRegionsDescription,
                                        TotalMaxWeightAllowed = item.TotalMaxWeightAllowed,
                                        TypeOfWarehouse = item.TypeOfWarehouse,
                                        WarehouseIllusha = item.WarehouseIllusha,
                                        WarehouseIndex = item.WarehouseIndex,
                                        WarehouseStatus = item.WarehouseStatus,
                                        WarehouseStatusDate = item.WarehouseStatusDate,
                                        WorkInMobileAwis = item.WarehouseStatusDate,
                                        CityId = city.Id,
                                        Delivery = new WorkScheduleEntity()
                                        {
                                            Saturday = item.Delivery.Saturday,
                                            Sunday = item.Delivery.Sunday,
                                            Friday = item.Delivery.Friday,
                                            Thursday = item.Delivery.Thursday,
                                            Wednesday = item.Delivery.Wednesday,
                                            Tuesday = item.Delivery.Tuesday,
                                            Monday = item.Delivery.Monday,
                                        },
                                        Schedule = new WorkScheduleEntity()
                                        {
                                            Saturday = item.Schedule.Saturday,
                                            Sunday = item.Schedule.Sunday,
                                            Friday = item.Schedule.Friday,
                                            Thursday = item.Schedule.Thursday,
                                            Wednesday = item.Schedule.Wednesday,
                                            Tuesday = item.Schedule.Tuesday,
                                            Monday = item.Schedule.Monday,
                                        },
                                        Reception = new WorkScheduleEntity()
                                        {
                                            Saturday = item.Reception.Saturday,
                                            Sunday = item.Reception.Sunday,
                                            Friday = item.Reception.Friday,
                                            Thursday = item.Reception.Thursday,
                                            Wednesday = item.Reception.Wednesday,
                                            Tuesday = item.Reception.Tuesday,
                                            Monday = item.Reception.Monday,
                                        },
                                        ReceivingLimitationsOnDimensions = new DimensionsEntity()
                                        {
                                            Height = item.ReceivingLimitationsOnDimensions.Height,
                                            Length = item.ReceivingLimitationsOnDimensions.Length,
                                            Width = item.ReceivingLimitationsOnDimensions.Width
                                        },
                                        SendingLimitationsOnDimensions = new DimensionsEntity()
                                        {
                                            Height = item.SendingLimitationsOnDimensions.Height,
                                            Length = item.SendingLimitationsOnDimensions.Length,
                                            Width = item.SendingLimitationsOnDimensions.Width
                                        }
                                    };
                                    _context.Warehouses.Add(entity);
                                    _context.SaveChanges();
                                }
                            }
                        }
                    }
                }
            }
        }

        public List<AreaEntity> GetListAreas()
        {
            return _context.Areas.ToList();
        }
        public List<CityEntity> GetListCities()
        {
            return _context.Cities.ToList();
        }
        public List<WarehouseEntity> GetWarehouses()
        {
            return _context.Warehouses.ToList();
        }
    }
}
