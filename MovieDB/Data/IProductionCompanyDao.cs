namespace MovieDB.Data
{
    public interface IProductionCompanyDao
    {
        ProductionCompany AddProductionCompany(ProductionCompany productionCompany);
        void DeleteProductionCompany(ProductionCompany productionCompany);
    }
}
