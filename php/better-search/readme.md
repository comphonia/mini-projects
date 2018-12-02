
# About

Better Search was made as practice for implementing a search on my [blog](https://comphonia.com/blog/)

Usual SQL query for a search would be something like `SELECT posts FROM blog WHERE post_title LIKE %var%`.

While this works since it's straight forward, I wanted to take it a bit further to improve user experience, most especially fit a use case where a user searches for post name in a different order; such as "Crime True" instead of "True Crime" the LIKE clause will not find the later. This implementation will improve user experience as it will search LIKE '%True%' and '%Crime%' and its order will not matter.

Searching UX can be improved by using a SOUNDEX function to by providing the users with an alternative-to. for instance they types in "Texes" searching a state, LIKE clause would not find it, but SOUNDEX will, so you can make a suggestion (Did you mean "Texas" ?). This will be next up for implementation if I ever re-visit this.

# Usage
- Run the .sql query in your database to create a table and insert those values
- Change the sql username and password in `search.php` to yours
- Search an empty field to return all values
