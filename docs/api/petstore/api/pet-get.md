# Find pet by ID

```http
GET /pet/{petId}
```

Returns a single pet

## Parameters

| Parameter | Type | In | Description | Notes |
|:-|:-|:-|:-|
|`petId`|`int`|Path|ID of pet to return|**Required**<br/>**Deprecated**|

## Request headers
Do not supply a request header for this method.

## Request body
Do not supply a request body for this method.

## Responses
### 200 OK
successful operation.

[!include[pet](../json/pet.md)]
### 400
Invalid ID supplied

### 404
Pet not found

## Examples