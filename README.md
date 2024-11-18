### **Filter and Pagination with POST - Implementation Summary**

*URL: https://localhost:44369/filter/*

This implementation provides a **filterable** and **paginated** list across two separate pages in Umbraco. The flow ensures that both the **filtering** and **pagination** are handled via `POST` requests to maintain data integrity and security. 

#### **Steps Taken**:

1. **Filter Page**:
   - A form allows users to enter a **filter** term.
   - The form submits the filter data via `POST` to the controller's **FilterResults** action, which processes the data and redirects to the **result page**.

2. **Result Page**:
   - The **result page** receives the **filter** and **pagination** parameters via a `POST` request.
   - Displays filtered results and supports pagination with **page navigation links**.
   - Pagination buttons use `@Html.BeginUmbracoForm` to **submit the page number and filter** as a `POST` request, ensuring that the same filter is applied across page changes.

3. **Controller (`FilterPageController`)**:
   - Handles both the **filter** and **pagination** logic in the `FilterResults` action.
   - Retrieves the filter and page parameters, calculates the filtered data, and returns the results with the necessary pagination.

4. **Pagination**:
   - Pagination buttons on the result page are implemented with `@Html.BeginUmbracoForm`, submitting the **current page** and **filter** via `POST`.
   - The page number and filter are preserved across pagination clicks, providing a seamless user experience.

------------------------------------------

**Backoffice credentials**
user: test@test.com
password: test123456