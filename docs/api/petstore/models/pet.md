# Pet model

## Methods

| Method | Return Type | Description |
|:-|:-|:-|
| [Get pet](../api/pet-get.md) | [pet](pet.md) | Find pet by ID |

## Properties

| Property | Type | Description | Notes |
|:-|:-|:-|:-|
|`id`|[id](id.md)|Pet ID| [Find more info here](https://example.com)|
|`category`|[category](category.md)|Categories this pet belongs to||
|`name`|`string`|The name given to a pet|`Required`<br/>**Examples:** Guru|
|`photoUrls`|`string[]`|The list of URL to a cute photos featuring pet|**Format:** url<br/>**Possible values:** `<= 20`|
|`friend`|[pet](pet.md)||
|`tag`|[tag[]](tag.md)|Tags attached to the pet|`Required`<br/>**Possible values:** `> 1`|
|`status`|`string`|Pet status in the store|`["available", "pending", "sold"]`|
|`petType`|`string`|Type of a pet||

## JSON representation

The following is a JSON representation of the model.

```json
{
  "id": 0,
  "category": {
    "id": 0,
    "name": "string",
    "sub": {
      "prop1": "string"
    }
  },
  "name": "Guru",
  "photoUrls": [
    "string"
  ],
  "friend": {},
  "tags": [
    {
      "id": 0,
      "name": "string"
    }
  ],
  "status": "available",
  "petType": "cat",
  "huntingSkill": "adventurous"
}
```