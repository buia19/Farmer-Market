## Schema Design

market

```
{
  stands: [
    // stand 1
    {
      locationId: 'stand_1_ID',
      farmer: { name: 'john', locationId: 'stand_1_ID' },
      ProduceDict: {
        banana: { quantity: 50, type: 'FRUIT' },
        orange: { quantity: 30, type: 'FRUIT' },
        apple: { quantity: 50, type: 'FRUIT' },
        tomato: { quantity: 5, type: 'VEGETABLE' },
        cabbage: { quantity: 5, type: 'VEGETABLE' },
      }
    },
    // stand 2
    {
      locationId: 'stand_2_ID',
      farmer: { name: 'anthony', locationId: 'stand_2_ID' },
      ProduceDict: {
        banana: { quantity: 50, type: 'FRUIT' },
        orange: { quantity: 30, type: 'FRUIT' }
      }
    },
    // ... more stands ...
  ],
  FarmerDict: {
    banana: [
      { name: 'john', locationId: 'stand_1_ID' },
      { name: 'anthony', locationId: 'stand_2_ID' },
    ],
    orange: [
      { name: 'john', locationId: 'stand_1_ID' },
      { name: 'anthony', locationId: 'stand_2_ID' },
    ],
    apple: [
      { name: 'john', locationId: 'stand_1_ID' }
    ],
    tomato: [
      { name: 'john', locationId: 'stand_1_ID' }
    ],
    cabbage: [
      { name: 'john', locationId: 'stand_1_ID' }
    ]
  }
}
```
