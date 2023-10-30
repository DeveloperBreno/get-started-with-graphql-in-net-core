# get-started-with-graphql-in-net-core

## link documentation
https://chillicream.com/docs/hotchocolate/v13/get-started-with-graphql-in-net-core

### run
dotnet run

### open web browser 
http://localhost:{{application_port}}/graphql


Go to "Operations"

paste this:

`
{ 
  book {
    title
    author {
      name
      }
    }
}
`


### Note:

In this json above you can choose which attributes you want to know, as well as navigation between classes.

and click in run button
