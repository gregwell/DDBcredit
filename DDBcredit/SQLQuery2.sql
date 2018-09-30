select a.Street, Apartment_No, City from Adresses a
inner join CustomerAdress b on a.Id = b.AdressId
where b.CustomerId =1