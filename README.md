bql-format-tool
===============

BQL formatting tool.
Feel free to embed it in any editor you like.

Usage:
------

stdin:
```
    Where<Table.Field, Equals<Current<Table.Field>>, Or<Equals<Required<Table.Field>>>>
```

stdout:
```
    Where<
        Table.Field,
        Equals<
            Current<
                Table.Field>>,
        Or<
            Equals<
                Required<
                    Table.Field>>>>
```
