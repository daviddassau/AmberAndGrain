# Amber and Grain
Our class distillery. Whiskey and other things made with grain.

- [ ] Create recipe
  - `Recipes` table
    - `Id` (points to `RecipeId` on the `Batch` table)
    - `Name`
    - `Percent Wheat`
    - `Percent Corn`
    - `Barrel Age`
    - `Barrel Material`
    - `Creator`
  - `Batch` table
    - `Id`
    - `RecipeId`
    - `DateCreated`
    - `DateBarrelled`
    - `DateBottled`
    - `Cooker`

- [ ] Mash

- [ ] Distill

- [ ] Barrel

- [ ] Taste Whiskey
  - what size taste?

- [ ] Bottle

- [ ] Sell
  - how many bottles
