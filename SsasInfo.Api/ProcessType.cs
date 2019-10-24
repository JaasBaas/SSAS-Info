using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SsasInfo.Api
{
    //
    // Summary:
    //     Describes the processing types available on the server.
    public enum ProcessType
    {
        //
        // Summary:
        //     Processes an Analysis Services object and all the objects contained within it.
        //     When Process Full is executed against an object that has already been processed,
        //     Analysis Services drops all data in the object, and then processes the object.
        //     Note that this type of processing is required when a structural change has been
        //     made to an object, for example, when an attribute hierarchy is added, deleted,
        //     or renamed. This processing option is supported for cubes, databases, dimensions,
        //     measure groups, mining models, mining structures, and partitions. Can be used
        //     for databases, dimensions, cubes, measure groups, partitions, mining structures,
        //     and mining models.
        ProcessFull = 0,
        //
        // Summary:
        //     Performs an incremental update. Can be used for dimensions and partitions.
        ProcessAdd = 1,
        //
        // Summary:
        //     Forces a re-read of data and an update of dimension attributes. Flexible aggregations
        //     and indexes on related partitions will be dropped. For example, this processing
        //     option can add new members to a dimension and force a complete re-read of the
        //     data to update object attributes. This processing option is supported for dimensions
        //     and mining models. Can be used for dimensions.
        ProcessUpdate = 2,
        //
        // Summary:
        //     Creates or rebuilds indexes for all processed partitions. This option results
        //     in no operation on unprocessed objects. This processing option is supported for
        //     cubes, dimensions, measure groups, and partitions. Can be used for dimensions,
        //     cubes, measure groups, and partitions.
        ProcessIndexes = 3,
        //
        // Summary:
        //     Processes data only without building aggregations or indexes. If there is data
        //     is in the partitions, it will be dropped before re-populating the partition with
        //     source data. This processing option is supported for cubes, measure groups, and
        //     partitions. Can be used for dimensions, cubes, measure groups, and partitions.
        ProcessData = 4,
        //
        // Summary:
        //     Detects the state of the object to be processed, and performs whatever type of
        //     processing (such as Full or Incremental) that is needed to return it to a fully
        //     processed state. This processing option is valid for databases, dimensions, cubes
        //     with measure groups and partitions, and mining structures with mining models.
        ProcessDefault = 5,
        //
        // Summary:
        //     Removes data, aggregations, and indexes. Can be used for databases, dimensions,
        //     cubes, measure groups, partitions, mining structures, and mining models.
        ProcessClear = 6,
        //
        // Summary:
        //     If the cube is unprocessed, Analysis Services will process, if necessary, all
        //     of the cube's dimensions. After that, Analysis Services will create only cube
        //     definitions. This allows users to start browsing the cube. If this option is
        //     applied to a mining structure, it populates the mining structure with source
        //     data. The difference between this option and the Process Full option is that
        //     this option does not iterate the processing down to the mining models themselves.
        //     This processing option is supported for cubes and mining structures. Can be used
        //     for cubes and mining structures.
        ProcessStructure = 7,
        //
        // Summary:
        //     Removes all training data from a mining structure. This processing option is
        //     supported for mining structures only. Can be used for mining structures.
        ProcessClearStructureOnly = 8,
        //
        // Summary:
        //     Rebuilds the MDX script cache if the cube is already processed. An error will
        //     be generated if the cube is not already processed. Can be used for cubes.
        ProcessScriptCache = 9,
        //
        // Summary:
        //     Specifies the type as ProcessRecalc.
        ProcessRecalc = 10,
        //
        // Summary:
        //     Applies to the entire measure group, not on individual partitions, to defragment
        //     internal dictionary structures.
        ProcessDefrag = 11
    }
}
