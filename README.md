bql-format-tool
===============

BQL formatting tool.

Input:
    Where<Table.Field, Equals<Current<Table.Field>>, Or<Equals<Required<Table.Field>>>>
    
Output:
    Where<
    Table.Field,
    Equals<
        Current<
            Table.Field>>,
    Or<
        Equals<
            Required<
                Table.Field>>>>
