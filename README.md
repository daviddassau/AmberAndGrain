# Amber and Grain
Our class distillery. Whiskey and other things made with grain.

- [x] Create recipe

- [x] Batch

- [ ] Distill

- [ ] Barrel

- [ ] Taste Whiskey
  - what size taste?

- [ ] Bottle

- [ ] Sell
  - how many bottles

- `Recipes` table
  - `Id` (points to `RecipeId` on the `Batches` table)
  - `Name`
  - `Percent Wheat`
  - `Percent Corn`
  - `Barrel Age`
  - `Barrel Material`
  - `Creator`
- `Batches` table
  - `Id` (points to `BatchId` on the `Orders` table)
  - `RecipeId`
  - `DateCreated`
  - `DateBarrelled`
  - `DateBottled`
  - `NumberOfBarrels`
  - `DateBottled`
  - `NumberOfBottles`
  - `Cooker`
  - `PricePerBottle`
  - `NumberOfBottlesLeft`
- `Orders` table
  - `Id`
  - `BatchId`
  - `NumberOfBottles`
  - `DateOfOrder`
  - `CustomerId`
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
  
