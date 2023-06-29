select pr.Name, cat.Name from Products pr
left join Categories cat on pr.Category = cat.primaryKey