select country_id from (select country_id, count(*) as counter2 from Students group by country_ID ) b where b.counter2 = (select max(counter2) from (select country_id, count(*) as counter2 from Students group by country_ID ) b )
