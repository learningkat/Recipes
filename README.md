# Recipes
## Introduction
<p>This is an ASP.Net Core App made to organize recipes and make my weekly meal prep day easier to navigate.</p>
<p>Currently displays recipes from local database in an uncluttered way, eliminating reliance on lengthy blogs, and inconsistent memories of personal changes to those recipes. </p>
<p>Later features will include meal planning and shopping list functionality.</p>


## Technologies
<ul>
<li>ASP.NET Core</li>
<li>Razor Pages</li>
<li>Bootstrap 4</li>
<li>Entity Framework Core</li>
<li>SQL Database</li>

</ul>



### Home Page 
<img src="https://user-images.githubusercontent.com/42903139/110158808-d4f14180-7db7-11eb-9abe-afdbae94a977.png" width="750" />

### Gallery View
<img src="https://user-images.githubusercontent.com/42903139/110158942-05d17680-7db8-11eb-913b-5134ea9fac56.png" width="750" />

This page uses the Bootstrap card component to display all the recipes currently in the database.  The background image corresponds to the cuisine type and the icon corresonds to the course (Main, side, soup, etc).

### Individual Recipe View
<img src="https://user-images.githubusercontent.com/42903139/110158947-0702a380-7db8-11eb-8ebb-598373942084.png" width="750" />

This view is the heart of the project.  This page that gives all the information needed on one page that I don't have to scroll extensively and search for information as I cook. 


## Future Features
<ul>
<li>Filtering - User will be able to filter recipes by Cuisine or Course.  Perhaps eventually search ingredient or cook time. </li>
<li>Meal planning and shopping - User will be able to select several recipes for a week, review that they have an appropriate number of dishes in each category and send (most likely via email) themselves a shopping list generated from the ingredients of those recipes.</li>
<li>Changing recipe amounts - User will be able to half/double/other a recipe.</li>
<li>Nutrition calculation</li>
<li>Input - Currently recipes are entered directly into the database.  The app needs a one page, user friendly entry tool as well as single page editing.</li>
</ul>
