select distinct u.id, u.name from users u
join orders o on u.id = o.user_id
order by u.name