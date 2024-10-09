# Veridian-Insurance

<div align="center">
    <a href="http://www.youtube.com/watch?v=jhaxFaT-6fk" title="In-app videos">
        <img src="http://img.youtube.com/vi/jhaxFaT-6fk/0.jpg" width="50%">
    </a>
    <p>Click the link to see the full in-app video: https://youtu.be/jhaxFaT-6fk</p>
</div>

I participated in an internship program organized by Ada Yazilim. The program focused on developing a simple web or mobile insurance application, comprising both the front end and the back end. Attendees were free to choose the technologies they felt most comfortable with. As a beginner in both web and mobile development, I chose to work on a web application and preferred ASP.NET as my primary technology.

Since I was inexperienced in web development and lacked sufficient knowledge, my first step was to select the technologies to learn. I chose ASP.NET, a technology developed by Microsoft that is commonly used worldwide. Because it has a strong community and abundant resources for learning, I decided to work with it. Additionally, I opted for the Model-View-Controller (MVC) architecture because it is a widely used architecture in web development, making numerous resources available online.

The application uses the Identity Framework for registration and login operations. There are two roles: "consultant" (employee) and "admin." The admin role has the privilege to access an admin panel that allows for analyzing the performance of the consultants. Both consultants and admins can add and delete customers, and they can generate offers and sign insurance policies within the scope of "health," "vehicle," and "earthquake."

<p align="center">
  <img src="https://github.com/canerkaynak/Veridian-Insurance/blob/master/database.png" width="500" align="center">
</p>

The database was created using a code-first approach with Entity Framework. We have tables for users, customers, policies (for common attributes across all policies), each insurance type, payments, and vehicle insurance prices, as shown above.
